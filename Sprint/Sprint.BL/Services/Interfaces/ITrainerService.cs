using Sprint.BL.Dto.CourtReservation;
using Sprint.BL.Dto.Trainer;

namespace Sprint.BL.Services.Interfaces;

public interface ITrainerService
{
    Task<TrainerDto> AddTrainer(Guid userId, string description, decimal hourlyRate);
    Task<TrainerDto?> GetTrainer(Guid userId);
    Task<List<CourtReservationDto>?> GetDailySchedule(Guid trainerId);
}
