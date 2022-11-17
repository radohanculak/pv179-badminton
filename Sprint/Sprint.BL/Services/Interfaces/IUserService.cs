using Sprint.BL.Dto.User;

namespace Sprint.BL.Services.Interfaces;

public interface IUserService
{
    Task<UserDto> Register(UserCreateDto user);
    Task<UserDto> Login(UserCreateDto user);
    Task<bool> Logout(UserCreateDto user);
    Task<bool> ChangePassword(Guid userId, string hash);
    Task<UserDto> GetUserAsync(Guid userId);
    Task<UserDto> AddUserAsync(string name, string lastName, string email, DateTime dateOfBirth);
}
