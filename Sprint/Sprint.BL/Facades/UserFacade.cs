using Sprint.BL.Dto.Trainer;
using Sprint.BL.Dto.User;
using Sprint.BL.Facades.Interfaces;
using Sprint.BL.Services.Interfaces;
using Sprint.Common.Enums;

namespace Sprint.BL.Facades;

public class UserFacade : IUserFacade
{
    private readonly IUserService _userService;
    private readonly ITrainerService _trainerService;
    private readonly ICourtReservationService _courtResService;
    private readonly ITrainerReservationService _trainerResService;
    
    public UserFacade(IUserService userService, ITrainerService trainerService,
        ICourtReservationService courtResService, ITrainerReservationService trainerResService)
    {
        _userService = userService;
        _trainerService = trainerService;
        _courtResService = courtResService;
        _trainerResService = trainerResService;
    }

    public async Task<(UserDto, TrainerDto)> AddTrainerAsync(UserDto user, string description, decimal hourlyRate)
    {
        var userDto = await _userService.AddUserAsync(user);
        
        var trainerDto = await _trainerService.AddTrainerAsync(userDto.Id, description, hourlyRate);

        return (userDto, trainerDto);
    }

    public async Task<UserDto> AddUserAsync(UserDto user)
    {
        return await _userService.AddUserAsync(user);
    }

    public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
    {
        return await _userService.GetAllUsersAsync();
    }

    public async Task<UserDto> GetUserAsync(Guid userId)
    {
        return await _userService.GetUserAsync(userId);
    }

    public async Task UpdateUserAsync(Guid userId, string firstName, string lastName, string email, string password, UserRole role)
    {
        await _userService.UpdateUserAsync(userId, firstName, lastName, email, password, role);
    }
    
    public async Task UserChangeRoleAsync(Guid userId, UserRole role)
    {
        await _userService.UserChangeRoleAsync(userId, role);
    }

    public async Task<UserDto> GetUserByEmailAsync(string email)
    {
        return await _userService.GetUserByEmailAsync(email);
    }

    public async Task DeleteUserAsync(Guid userId)
    {
        var user = await _userService.GetUserAsync(userId);
        foreach (var reservation in user.CourtReservations)
        {
            if (reservation.From > DateTime.Now)
            {
                await _courtResService.DeleteReservationAsync(reservation.Id);
            }
        }
        
        await _userService.DeleteUserAsync(userId);
    }
}
