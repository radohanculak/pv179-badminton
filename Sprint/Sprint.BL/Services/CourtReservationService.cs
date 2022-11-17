using Ardalis.GuardClauses;
using AutoMapper;
using Sprint.BL.Dto.Court;
using Sprint.BL.Dto.CourtReservation;
using Sprint.BL.Dto.User;
using Sprint.BL.Services.Interfaces;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.UnitOfWork;

namespace Sprint.BL.Services;

public class CourtReservationService : ICourtReservationService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public CourtReservationService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<CourtReservationDto> AddReservation(Guid userId, Guid courtId, DateTime from, DateTime to)
    {
        Guard.Against.Null(userId);
        Guard.Against.Null(courtId);
        Guard.Against.Null(from);
        Guard.Against.Null(to);

        var user = await _unitOfWork.UserRepository.GetByIdAsync(userId);
        var userDto = _mapper.Map<UserDto>(user);

        var court = await _unitOfWork.CourtRepository.GetByIdAsync(courtId);
        var courtDto =  _mapper.Map<CourtDto>(court);

        var courtReservation = new CourtReservationDto
        {
            From = from,
            To = to,
            User = userDto,
            Court = courtDto,
            Created = DateTime.Now // TODO - toto se musi nastavovat pri insertu do db
        };

        var reservationId = await _unitOfWork.CourtReservationRepository
            .InsertAsync(_mapper.Map<CourtReservation>(courtReservation));

        await _unitOfWork.CommitAsync();

        var reservation = await _unitOfWork.CourtReservationRepository.GetByIdAsync(reservationId);

        return _mapper.Map<CourtReservationDto>(reservation);
    }

    public async Task<CourtReservationDto> GetReservation(Guid reservationId)
    {
        var reservation = await _unitOfWork.CourtReservationRepository.GetByIdAsync(reservationId);

        if (reservation == null)
        {
            new InvalidOperationException($"Reservation with id {reservationId} does not exist");
        }

        return _mapper.Map<CourtReservationDto>(reservation);
    }

    public async Task<List<CourtReservationDto>> GetAllReservations()
    {
        var reservations = await _unitOfWork.CourtReservationRepository.GetAllAsync();

        return _mapper.Map<List<CourtReservationDto>>(reservations);
    }

    public async Task<List<CourtReservationDto>> GetReservations(Guid userId, bool inPast)
    {
        var userReservations = (await GetAllReservations()).Where(r => r.User.Id == userId);

        if (inPast)
        {
            return userReservations.ToList();
        }

        return userReservations.Where(r => r.From.Date >= DateTime.Now).ToList();
    }

    public async Task<List<CourtReservationDto>> GetReservations(Guid userId, DateTime from, DateTime to)
    {
        return (await GetAllReservations())
            .Where(r => r.User.Id == userId && r.From >= from && r.To <= to)
            .ToList();
    }

    public async Task DeleteReservation(Guid reservationId)
    {
        // if reservation does not exists method throws exception
        var reservation = await GetReservation(reservationId);

        var a = _unitOfWork.CourtReservationRepository.GetByIdAsync(reservationId);

        await _unitOfWork.CourtReservationRepository.DeleteByIdAsync(reservationId);
        await _unitOfWork.CommitAsync();
    }
}
