using Sprint.BL.Dto.TrainerReservation;

namespace Sprint.BL.Services.Interfaces;

public interface ITrainerReservationService
{
    Task<TrainerReservationDto> AddReservationAsync(Guid userId, Guid trainerId, Guid courtId, DateTime from, DateTime to);
    Task<TrainerReservationDto> GetReservationAsync(Guid reservationId);
    Task<List<TrainerReservationDto>> GetAllReservationsAsync();
    Task<List<TrainerReservationDto>> GetReservationsForTrainerAsync(Guid trainerId, bool inPast);
    Task<List<TrainerReservationDto>> GetReservationsForUserAsync(Guid userId, bool inPast);
    Task<List<TrainerReservationDto>?> GetTrainerDailyScheduleAsync(Guid trainerId, DateTime date);
    Task DeleteReservationAsync(Guid reservationId, bool keepCourtReservation);
}
