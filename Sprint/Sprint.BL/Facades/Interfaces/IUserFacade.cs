using Sprint.BL.Dto.Trainer;
using Sprint.BL.Dto.User;

namespace Sprint.BL.Facades.Interfaces;

public interface IUserFacade
{
    Task<UserDto> Register(UserCreateDto user);
    Task<UserDto> Login(UserCreateDto user);
    Task<bool> Logout(UserCreateDto user);
    Task<bool> ChangePassword(Guid userId, string hash);
    Task<UserDto> GetUserAsync(Guid userId);
    Task<UserDto> AddUserAsync(string name, string lastName, string email, DateTime dateOfBirth);
    Task<IEnumerable<UserDto>> GetAllUsersAsync();
    Task UpdateUserAsync(Guid userId, string firstName, string lastName, string email, string password);
}