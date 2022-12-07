using Sprint.BL.Dto.Trainer;
using Sprint.BL.Dto.User;

namespace Sprint.BL.Services.Interfaces;

public interface ITrainerService
{
    Task<TrainerDto> AddTrainerAsync(Guid userId, string description, decimal hourlyRate);
    Task<TrainerDto> GetTrainerAsync(Guid trainerId);
    TrainerDto GetTrainerByUser(UserDto user);
}
