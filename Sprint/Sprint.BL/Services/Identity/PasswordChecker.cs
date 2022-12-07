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
        // var hp = new PasswordHasher<UserDto>().HashPassword(null, providedPassword);
        // return hashedPassword == hp ? PasswordVerificationResult.Success : PasswordVerificationResult.Failed;
        // TODO Fix hashing!
        return PasswordVerificationResult.Success;
    }
}