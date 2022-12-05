using Sprint.BL.Dto.CourtReservation;
using Sprint.BL.Dto.Trainer;
using Sprint.BL.Dto.TrainerReservation;

namespace Sprint.BL.Services.Interfaces;

public interface ITrainerReservationService
{
    Task<TrainerReservationDto> AddReservationAsync(CourtReservationDto courtReservation, Guid trainerId);
    Task<TrainerReservationDto> GetReservationAsync(Guid reservationId);
    Task<List<TrainerReservationDto>> GetAllReservationsAsync();
    List<TrainerReservationDto> GetReservationsForTrainer(TrainerDto trainer, bool inPast);
    Task<List<TrainerReservationDto>> GetReservationsForUserAsync(Guid userId, bool inPast);
    List<TrainerReservationDto>? GetTrainerDailySchedule(TrainerDto trainer, DateTime date);
    Task DeleteReservationAsync(TrainerReservationDto reservation);
}
