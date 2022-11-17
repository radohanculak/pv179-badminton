using Ardalis.GuardClauses;
using AutoMapper;
using Sprint.BL.Dto.CourtReservation;
using Sprint.BL.Services.Interfaces;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.UnitOfWork;

namespace Sprint.BL.Services;

public class CourtReservationService : ICourtReservationService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserService _userService;
    private readonly ICourtService _courtService;

    public CourtReservationService(IUnitOfWork unitOfWork, IMapper mapper, IUserService userService, ICourtService courtService)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _userService = userService;
        _courtService = courtService;
    }

    public async Task<CourtReservationDto> AddReservationAsync(Guid userId, Guid courtId, DateTime from, DateTime to)
    {
        Guard.Against.Null(from);
        Guard.Against.Null(to);

        var user = await _userService.GetUserAsync(userId);
        var court = await _courtService.GetCourtAsync(courtId);

        var courtReservation = new CourtReservationCreateDto
        {
            From = from,
            To = to,
            User = user,
            Court = court,
            Created = DateTime.Now // TODO - toto se musi nastavovat pri insertu do db
        };

        var reservationId = await _unitOfWork.CourtReservationRepository
            .InsertAsync(_mapper.Map<CourtReservation>(courtReservation));

        await _unitOfWork.CommitAsync();

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

    public async Task<List<CourtReservationDto>> GetAllReservationsAsync()
    {
        var reservations = await _unitOfWork.CourtReservationRepository.GetAllAsync();

        return _mapper.Map<List<CourtReservationDto>>(reservations);
    }

    public async Task<List<CourtReservationDto>> GetReservationsAsync(Guid userId, bool inPast)
    {
        var userReservations = (await GetAllReservationsAsync()).Where(r => r.User.Id == userId);

        if (inPast)
        {
            return userReservations.ToList();
        }

        return userReservations.Where(r => r.From.Date >= DateTime.Now).ToList();
    }

    public async Task<List<CourtReservationDto>> GetReservationsAsync(Guid userId, DateTime from, DateTime to)
    {
        return (await GetAllReservationsAsync())
            .Where(r => r.User.Id == userId && r.From >= from && r.To <= to)
            .ToList();
    }

    public async Task DeleteReservationAsync(Guid reservationId)
    {
        // if reservation does not exists method throws exception
        var reservation = await GetReservationAsync(reservationId);

        reservation.IsDeleted = true;

        _unitOfWork.CourtReservationRepository.Update(_mapper.Map<CourtReservation>(reservation));
        await _unitOfWork.CommitAsync();
    }
}
