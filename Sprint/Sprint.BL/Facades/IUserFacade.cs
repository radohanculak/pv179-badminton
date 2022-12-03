using Sprint.BL.Dto.Trainer;
using Sprint.BL.Dto.User;

namespace Sprint.BL.Facades;

public interface IUserFacade
{
    public Task<(UserDto, TrainerDto)> AddTrainerAsync(string firstName, string lastName,
        string email, DateTime dateOfBirth, string description, decimal hourlyRate);
    
    public Task<IEnumerable<UserDto>> GetAllUsersAsync();
}