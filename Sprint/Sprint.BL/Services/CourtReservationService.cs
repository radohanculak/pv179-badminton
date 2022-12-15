using Ardalis.GuardClauses;
using AutoMapper;
using Sprint.BL.Dto.CourtReservation;
using Sprint.BL.Dto.User;
using Sprint.BL.Services.Interfaces;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.UnitOfWork;
using Sprint.Infrastructure.Query;

namespace Sprint.BL.Services;

public class CourtReservationService : ICourtReservationService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IQueryObject<CourtReservation> queryObject;

    public CourtReservationService(IUnitOfWork unitOfWork, IMapper mapper, IQueryObject<CourtReservation> queryObject)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        this.queryObject = queryObject;
    }

    public async Task<CourtReservationDto> AddReservationAsync(Guid userId, Guid courtId, DateTime from, DateTime to)
    {
        Guard.Against.Null(from);
        Guard.Against.Null(to);

        var courtReservation = new CourtReservationDto
        {
            From = from,
            To = to,
            UserId = userId,
            CourtId = courtId,
            Created = DateTime.Now
        };

        var reservationId = await _unitOfWork.CourtReservationRepository
            .InsertAsync(_mapper.Map<CourtReservation>(courtReservation));

        await _unitOfWork.CommitAsync();
        _unitOfWork.CourtReservationRepository.ClearTracking();

        return await GetReservationAsync(reservationId);
    }

    public async Task<CourtReservationDto> GetReservationAsync(Guid reservationId)
    {
        var reservation = await _unitOfWork.CourtReservationRepository.GetByIdAsync(reservationId);

        if (reservation == null)
        {
            throw new InvalidOperationException($"Reservation with id {reservationId} does not exist");
        }

        return _mapper.Map<CourtReservationDto>(reservation);
    }

    public async Task<List<CourtReservationDto>> GetAllReservationsAsync(bool alsoDeleted)
    {
        var reservations = await _unitOfWork.CourtReservationRepository.GetAllAsync();

        if (!alsoDeleted)
        {
            return _mapper.Map<List<CourtReservationDto>>(reservations.Where(r => !r.IsDeleted));
        }
        
        return _mapper.Map<List<CourtReservationDto>>(reservations);
    }

    public List<CourtReservationDto> GetReservations(UserDto user, bool inPast, bool alsoDeleted)
    {
        IEnumerable<CourtReservationDto> reservations = user.CourtReservations;
        if (!alsoDeleted)
        {
            reservations = reservations.Where(r => !r.IsDeleted);
        }

        if (inPast)
        {
            return reservations.ToList();
        }

        return reservations
            .Where(r => r.From.Date >= DateTime.Now.Date)
            .ToList();
    }

    public List<CourtReservationDto> GetReservations(UserDto user, DateTime from, DateTime to, bool alsoDeleted)
    {
        IEnumerable<CourtReservationDto> reservations = user.CourtReservations
            .Where(r => r.From >= from && r.To <= to);
        
        if (!alsoDeleted)
        {
            reservations = reservations.Where(r => !r.IsDeleted);
        }
        
        return reservations.ToList();
    }

    public async Task DeleteReservationAsync(Guid reservationId)
    {
        // if reservation does not exists method throws exception
        var reservation = await GetReservationAsync(reservationId);

        reservation.IsDeleted = true;

        _unitOfWork.CourtReservationRepository.Update(_mapper.Map<CourtReservation>(reservation));
        await _unitOfWork.CommitAsync();
        _unitOfWork.CourtReservationRepository.ClearTracking();
    }

    public async Task<List<CourtReservationDto>> GetReservationsForDayAsync(DateTime date)
    {
        var reservations = await queryObject.Filter(x => x.From.Date == date && x.To.Date == date && x.IsDeleted == false).ExecuteAsync();
        return _mapper.Map<List<CourtReservationDto>>(reservations);
    }
}
