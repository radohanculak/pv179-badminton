using Ardalis.GuardClauses;
using AutoMapper;
using Sprint.BL.Dto.Court;
using Sprint.BL.Dto.CourtReservation;
using Sprint.BL.Services.Interfaces;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.Query;
using Sprint.Infrastructure.UnitOfWork;

namespace Sprint.BL.Services;

public class CourtService : ICourtService
{
    private readonly IMapper _mapper;
    private readonly IQueryObject<Court> queryObject;
    private readonly IUnitOfWork _unitOfWork;

    public CourtService(IUnitOfWork unitOfWork, IMapper mapper, IQueryObject<Court> queryObject)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        this.queryObject = queryObject;
    }

    public async Task<CourtDto> AddCourtAsync(string courtNumber, decimal hourlyRate)
    {
        Guard.Against.NegativeOrZero(hourlyRate);
        Guard.Against.NullOrWhiteSpace(courtNumber);

        var newCourt = new CourtDto
        {
            HourlyRate = hourlyRate,
            CourtNumber = courtNumber
        };

        var courtId = await _unitOfWork.CourtRepository.InsertAsync(_mapper.Map<Court>(newCourt));

        await _unitOfWork.CommitAsync();
        _unitOfWork.CourtRepository.ClearTracking();

        return await GetCourtAsync(courtId);
    }

    public async Task<CourtDto> GetCourtAsync(Guid courtId)
    {
        var court = await _unitOfWork.CourtRepository.GetByIdAsync(courtId);

        if (court == null)
        {
            throw new InvalidOperationException($"Court with id {courtId} does not exist");
        }

        return _mapper.Map<CourtDto>(court);
    }

    public async Task<List<CourtDto>> GetCourtsAsync()
    {
        var courts = await _unitOfWork.CourtRepository.GetAllAsync();

        return _mapper.Map<List<CourtDto>>(courts);
    }

    public async Task<List<CourtDto>> GetCourtsAsync(int page, int pageSize)
    {
        queryObject
            .OrderBy(x => x.CourtNumber)
            .Page(page, pageSize);

        var result = await queryObject.ExecuteAsync();

        return _mapper.Map<List<CourtDto>>(result);
    }

    public async Task<IEnumerable<CourtReservationDto>> GetDailyScheduleAsync(Guid courtId, DateTime date)
    {
        var reservations = await _unitOfWork.CourtReservationRepository.GetAllAsync();
        var selectedReservations = reservations
            .Where(r => r.CourtId == courtId && r.From.Date == date.Date)
            .ToList();

        return _mapper.Map<List<CourtReservationDto>>(selectedReservations);
    }

    public async Task UpdateCourtAsync(Guid courtId, string courtNumber, decimal hourlyRate)
    {
        var court = await _unitOfWork.CourtRepository.GetByIdAsync(courtId);

        if (court == null)
        {
            throw new InvalidOperationException($"User with id {courtId} does not exist");
        }

        court.CourtNumber = courtNumber;
        court.HourlyRate = hourlyRate;

        _unitOfWork.CourtRepository.Update(court);

        await _unitOfWork.CommitAsync();
        _unitOfWork.CourtRepository.ClearTracking();
    }
}
