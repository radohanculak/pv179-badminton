using Sprint.BL.Dto.Trainer;

namespace Sprint.BL.Facades.Interfaces;

public interface ITrainerFacade
{
    Task<TrainerDto> AddTrainerAsync(Guid userId, string description, decimal hourlyRate);
    Task<TrainerDto> GetTrainerAsync(Guid trainerId);
    Task<TrainerDto> GetTrainerByUserIdAsync(Guid userId);
}
