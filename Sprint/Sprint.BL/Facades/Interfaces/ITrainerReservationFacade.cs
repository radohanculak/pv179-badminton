using Sprint.BL.Dto.TrainerReservation;

namespace Sprint.BL.Facades.Interfaces;

public interface ITrainerReservationFacade
{
    Task<TrainerReservationDto> AddReservationAsync(Guid userId, Guid trainerId, Guid courtId, DateTime from, DateTime to);
    Task<TrainerReservationDto> GetReservationAsync(Guid reservationId);
    Task<List<TrainerReservationDto>> GetAllReservationsAsync(bool alsoDeleted);
    Task<List<TrainerReservationDto>> GetReservationsForTrainerAsync(Guid trainerId, bool inPast, bool alsoDeleted);
    Task<List<TrainerReservationDto>> GetReservationsForUserAsync(Guid userId, bool inPast, bool alsoDeleted);
    Task<List<TrainerReservationDto>?> GetTrainerDailyScheduleAsync(Guid trainerId, DateTime date);
    Task DeleteReservationAsync(Guid reservationId, bool keepCourtReservation);
}
