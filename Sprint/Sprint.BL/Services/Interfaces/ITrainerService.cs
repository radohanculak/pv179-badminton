using Sprint.BL.Dto.Trainer;
using Sprint.BL.Dto.TrainerReservation;

namespace Sprint.BL.Services.Interfaces;

public interface ITrainerService
{
    Task<TrainerDto> AddTrainer(Guid userId, string description, decimal hourlyRate);
    Task<TrainerDto> GetTrainer(Guid userId);
    Task<List<TrainerReservationDto>> GetDailySchedule(Guid trainerId);
}
