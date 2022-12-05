using Sprint.BL.Dto.TrainerReservation;
using Sprint.BL.Facades.Interfaces;
using Sprint.BL.Services.Interfaces;

namespace Sprint.BL.Facades;

public class TrainerReservationFacade : ITrainerReservationFacade
{
    private readonly ITrainerReservationService _trainerReservationService;
    private readonly ICourtReservationService _courtReservationService;
    private readonly ITrainerService _trainerService;

    public TrainerReservationFacade(ITrainerReservationService trainerReservationService,
        ICourtReservationService courtReservationService, ITrainerService trainerService)
    {
        _trainerReservationService = trainerReservationService;
        _courtReservationService = courtReservationService;
        _trainerService = trainerService;
    }

    public async Task<TrainerReservationDto> AddReservationAsync(Guid userId, Guid trainerId, Guid courtId, DateTime from, DateTime to)
    {
        _ = await _trainerService.GetTrainerAsync(trainerId);
        var courtReservation = await _courtReservationService.AddReservationAsync(userId, courtId, from, to);

        return await _trainerReservationService.AddReservationAsync(courtReservation, trainerId);
    }

    public async Task DeleteReservationAsync(Guid reservationId, bool keepCourtReservation)
    {
        var reservation = await _trainerReservationService.GetReservationAsync(reservationId);

        if (!keepCourtReservation)
        {
            await _courtReservationService.DeleteReservationAsync(reservation.CourtReservation.Id);
        }

        await _trainerReservationService.DeleteReservationAsync(reservation);
    }

    public async Task<List<TrainerReservationDto>> GetAllReservationsAsync()
    {
        return await _trainerReservationService.GetAllReservationsAsync();
    }

    public async Task<TrainerReservationDto> GetReservationAsync(Guid reservationId)
    {
        return await _trainerReservationService.GetReservationAsync(reservationId);
    }

    public async Task<List<TrainerReservationDto>> GetReservationsForTrainerAsync(Guid trainerId, bool inPast)
    {
        var trainer = await _trainerService.GetTrainerAsync(trainerId);

        return _trainerReservationService.GetReservationsForTrainer(trainer, inPast);
    }

    public async Task<List<TrainerReservationDto>> GetReservationsForUserAsync(Guid userId, bool inPast)
    {
        return await _trainerReservationService.GetReservationsForUserAsync(userId, inPast);
    }

    public async Task<List<TrainerReservationDto>?> GetTrainerDailyScheduleAsync(Guid trainerId, DateTime date)
    {
        var trainer = await _trainerService.GetTrainerAsync(trainerId);

        return _trainerReservationService.GetTrainerDailySchedule(trainer, date);
    }
}
