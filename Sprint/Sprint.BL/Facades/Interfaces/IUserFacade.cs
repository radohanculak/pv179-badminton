using Sprint.BL.Dto.User;
using Sprint.Common.Enums;

namespace Sprint.BL.Facades.Interfaces;

public interface IUserFacade
{
    // Task<UserDto> Register(UserCreateDto user);
    // Task<UserDto> Login(UserCreateDto user);
    // Task<bool> Logout(UserCreateDto user);
    // Task<bool> ChangePassword(Guid userId, string hash);
    Task<UserDto> GetUserAsync(Guid userId);
    Task<UserDto> AddUserAsync(UserDto user);
    Task<IEnumerable<UserDto>> GetAllUsersAsync();
    Task UpdateUserAsync(Guid userId, string firstName, string lastName, string email, string password, UserRole role);
    Task UserChangeRoleAsync(Guid userId, UserRole role);
    Task<UserDto> GetUserByEmailAsync(string email);
    public Task DeleteUserAsync(Guid userId);
}