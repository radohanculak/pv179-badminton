using Ardalis.GuardClauses;
using AutoMapper;
using Sprint.BL.Dto.TrainerReservation;
using Sprint.BL.Services.Interfaces;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.UnitOfWork;

namespace Sprint.BL.Services;

public class TrainerReservationService : ITrainerReservationService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ITrainerService _trainerService;
    private readonly ICourtReservationService _courtReservationService;
    private readonly IUserService _userService;

    public TrainerReservationService(IUnitOfWork unitOfWork, IMapper mapper,
        ICourtReservationService courtService, ITrainerService trainerService, IUserService userService)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _courtReservationService = courtService;
        _trainerService = trainerService;
        _userService = userService;
    }

    public async Task<TrainerReservationDto> AddReservationAsync(Guid userId, Guid trainerId, Guid courtId, DateTime from, DateTime to)
    {
        Guard.Against.Null(from);
        Guard.Against.Null(to);

        _ = await _trainerService.GetTrainerAsync(trainerId);
        var courtReservation = await _courtReservationService.AddReservationAsync(userId, courtId, from, to);

        var newTrainerReservation = new TrainerReservationCreateDto
        {
            TrainerId = trainerId,
            CourtReservationId = courtReservation.Id
        };

        var trainerReservationId = await _unitOfWork.TrainerReservationRepository
            .InsertAsync(_mapper.Map<TrainerReservation>(newTrainerReservation));
        await _unitOfWork.CommitAsync();

        return await GetReservationAsync(trainerReservationId);
    }

    public async Task<TrainerReservationDto> GetReservationAsync(Guid reservationId)
    {
        var reservation = await _unitOfWork.TrainerReservationRepository.GetByIdAsync(reservationId);

        if (reservation == null)
        {
            throw new InvalidOperationException($"Trainer reservation with id {reservationId} does not exist");
        }

        return _mapper.Map<TrainerReservationDto>(reservation);
    }

    public async Task<List<TrainerReservationDto>> GetAllReservationsAsync()
    {
        var reservations = await _unitOfWork.TrainerReservationRepository.GetAllAsync();

        return _mapper.Map<List<TrainerReservationDto>>(reservations);
    }

    public async Task<List<TrainerReservationDto>> GetReservationsForTrainerAsync(Guid trainerId, bool inPast)
    {
        var reservations = (await _trainerService.GetTrainerAsync(trainerId)).Reservations;

        if (inPast)
        {
            return reservations.ToList();
        }

        return reservations.Where(r => r.CourtReservation.From.Date >= DateTime.Now.Date).ToList();
    }

    // nefunguje - asi se pro to bude muset napsat repo, ve kterem se da Include na rezervace trenera
    public async Task<List<TrainerReservationDto>> GetReservationsForUserAsync(Guid userId, bool inPast)
    {
        var reservations = (await GetAllReservationsAsync()).Where(r => r.CourtReservation.UserId == userId);

        if (inPast)
        {
            return reservations.ToList();
        }

        return reservations.Where(r => r.CourtReservation.From.Date >= DateTime.Now.Date).ToList();
    }

    public async Task<List<TrainerReservationDto>?> GetTrainerDailyScheduleAsync(Guid trainerId, DateTime date)
    {
        var trainer = await _trainerService.GetTrainerAsync(trainerId);

        return trainer.Reservations.Where(r => r.CourtReservation.From.Date == date.Date).ToList();
    }

    public async Task DeleteReservationAsync(Guid reservationId, bool keepCourtReservation)
    {
        var reservation = await GetReservationAsync(reservationId);
        reservation.IsDeleted = true;

        if (!keepCourtReservation)
        {
            await _courtReservationService.DeleteReservationAsync(reservation.CourtReservation.Id);
        }

        _unitOfWork.CourtReservationRepository.Update(_mapper.Map<CourtReservation>(reservation));
        await _unitOfWork.CommitAsync();
    }
}
