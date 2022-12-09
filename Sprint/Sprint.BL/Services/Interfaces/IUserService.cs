using Sprint.BL.Dto.User;
using Sprint.Common.Enums;

namespace Sprint.BL.Services.Interfaces;

public interface IUserService
{
    // Task<UserDto> Register(UserDto user);
    // Task<UserDto> Login(UserDto user);
    // Task<bool> Logout(UserDto user);
    // Task<bool> ChangePassword(Guid userId, string hash);
    Task<UserDto> GetUserAsync(Guid userId);
    Task<UserDto> AddUserAsync(UserDto user);
    Task<IEnumerable<UserDto>> GetAllUsersAsync();
    Task UpdateUserAsync(Guid userId, string firstName, string lastName, string email, string password, UserRole role);
    Task<UserDto> GetUserByEmailAsync(string email);
    Task UserChangeRoleAsync(Guid userId, UserRole role);
}
