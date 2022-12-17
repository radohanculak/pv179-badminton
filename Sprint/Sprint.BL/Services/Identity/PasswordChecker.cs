using Microsoft.AspNetCore.Identity;
using Sprint.BL.Dto.User;

namespace Sprint.BL.Services.Identity;

public class PasswordChecker : IPasswordHasher<UserDto>
{
    public string HashPassword(UserDto user, string password)
    {
        return new PasswordHasher<UserDto>().HashPassword(null, password);
    }

    public PasswordVerificationResult VerifyHashedPassword(UserDto user, string hashedPassword, string providedPassword)
    {
        var ph = new PasswordHasher<UserDto>();
        return ph.VerifyHashedPassword(user, hashedPassword, providedPassword);
        // Uncomment for testing
        // return PasswordVerificationResult.Success;
    }
}