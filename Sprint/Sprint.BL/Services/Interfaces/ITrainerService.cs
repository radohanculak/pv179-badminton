using Sprint.BL.Dto.Trainer;
using Sprint.BL.Dto.User;

namespace Sprint.BL.Services.Interfaces;

public interface ITrainerService
{
    Task<TrainerDto> AddTrainerAsync(Guid userId, string description, decimal hourlyRate);
    Task<TrainerDto> GetTrainerAsync(Guid trainerId);
    TrainerDto GetTrainerByUser(UserDto user);
    Task<IEnumerable<TrainerDto>> GetAllTrainersAsync();
    Task<IEnumerable<TrainerDto>> GetFilteredTrainersAsync(int minPrice, int maxPrice);
    Task UpdateTrainerAsync(Guid trainerId, string description, decimal hourlyRate);
    Task DeleteTrainerAsync(Guid trainerId);
}
