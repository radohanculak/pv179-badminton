using Sprint.BL.Dto.Trainer;
using Sprint.BL.Dto.User;
using Sprint.BL.Facades.Interfaces;
using Sprint.BL.Services.Interfaces;

namespace Sprint.BL.Facades;

public class UserFacade : IUserFacade
{
    private readonly IUserService _userService;
    private readonly ITrainerService _trainerService;
    
    public UserFacade(IUserService userService, ITrainerService trainerService)
    {
        _userService = userService;
        _trainerService = trainerService;
    }

    public async Task<(UserDto, TrainerDto)> AddTrainerAsync(string firstName, string lastName,
        string email, DateTime dateOfBirth, string description, decimal hourlyRate)
    {
        var userDto = await _userService.AddUserAsync(firstName, lastName, email, dateOfBirth);
        
        var trainerDto = await _trainerService.AddTrainerAsync(userDto.Id, description, hourlyRate);

        return (userDto, trainerDto);
    }

    public async Task<UserDto> AddUserAsync(string name, string lastName, string email, DateTime dateOfBirth)
    {
        return await _userService.AddUserAsync(name, lastName, email, dateOfBirth);
    }

    public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
    {
        return await _userService.GetAllUsersAsync();
    }

    public async Task<UserDto> GetUserAsync(Guid userId)
    {
        return await _userService.GetUserAsync(userId);
    }

    public async Task UpdateUserAsync(Guid userId, string firstName, string lastName, string email, string password)
    {
        await _userService.UpdateUserAsync(userId, firstName, lastName, email, password);
    }

    public Task<UserDto> Login(UserCreateDto user)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Logout(UserCreateDto user)
    {
        throw new NotImplementedException();
    }

    public Task<UserDto> Register(UserCreateDto user)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ChangePassword(Guid userId, string hash)
    {
        throw new NotImplementedException();
    }
}