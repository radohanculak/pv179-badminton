using Sprint.BL.Dto.Trainer;
using Sprint.BL.Facades.Interfaces;
using Sprint.BL.Services.Interfaces;

namespace Sprint.BL.Facades;

public class TrainerFacade : ITrainerFacade
{
    private readonly ITrainerService _trainerService;
    private readonly IUserService _userService;

    public TrainerFacade(ITrainerService trainerService, IUserService userService)
    {
        _trainerService = trainerService;
        _userService = userService;
    }

    public async Task<TrainerDto> AddTrainerAsync(Guid userId, string description, decimal hourlyRate)
    {
        return await _trainerService.AddTrainerAsync(userId, description, hourlyRate);
    }

    public async Task<TrainerDto> GetTrainerAsync(Guid trainerId)
    {
        return await _trainerService.GetTrainerAsync(trainerId);
    }

    public async Task<TrainerDto> GetTrainerByUserIdAsync(Guid userId)
    {
        var user = await _userService.GetUserAsync(userId);

        return _trainerService.GetTrainerByUser(user);
    }
    
    public async Task<IEnumerable<TrainerDto>> GetAllTrainersAsync()
    {
        return await _trainerService.GetAllTrainersAsync();
    }
    
    public async Task UpdateTrainerAsync(Guid trainerId, string description, decimal hourlyRate)
    {
        await _trainerService.UpdateTrainerAsync(trainerId, description, hourlyRate);
    }
}
