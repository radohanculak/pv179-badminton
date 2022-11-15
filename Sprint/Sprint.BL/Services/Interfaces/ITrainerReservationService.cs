using Sprint.BL.Dto.TrainerReservation;

namespace Sprint.BL.Services.Interfaces;

public interface ITrainerReservationService
{
    Task<bool> AddReservation(TrainerReservationDto trainerReservation);
    Task<List<TrainerReservationDto>> GetReservations(Guid trainerId, bool all);
    Task<bool> DeleteReservation(Guid reservationId, bool keepCourtReservation);
}
