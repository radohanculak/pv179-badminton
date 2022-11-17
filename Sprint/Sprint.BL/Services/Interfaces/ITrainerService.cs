using Sprint.BL.Dto.Trainer;

namespace Sprint.BL.Services.Interfaces;

public interface ITrainerService
{
    Task<TrainerDto> AddTrainerAsync(Guid userId, string description, decimal hourlyRate);
    Task<TrainerDto> GetTrainerAsync(Guid trainerId);
    Task<TrainerDto> GetTrainerByUserIdAsync(Guid userId);
}
