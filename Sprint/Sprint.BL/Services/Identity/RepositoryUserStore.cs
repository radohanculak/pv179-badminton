using Microsoft.AspNetCore.Identity;
using Sprint.BL.Dto.User;
using Sprint.BL.Facades.Interfaces;
using Sprint.Common.Enums;


namespace Sprint.BL.Services.Identity;

public class RepositoryUserStore : IUserRoleStore<UserDto>, IUserPasswordStore<UserDto>, IUserEmailStore<UserDto>, IUserSecurityStampStore<UserDto>
{
    private readonly IUserFacade _userFacade;

    public RepositoryUserStore(IUserFacade userFacade)
    {
        _userFacade = userFacade;
    }
    
    public void Dispose()
    {
    }

    public Task<string> GetUserIdAsync(UserDto user, CancellationToken cancellationToken)
    {
        return Task.FromResult(user.Id.ToString());
    }

    public Task<string> GetUserNameAsync(UserDto user, CancellationToken cancellationToken)
    {
        return GetEmailAsync(user, cancellationToken);
    }

    public Task SetUserNameAsync(UserDto user, string userName, CancellationToken cancellationToken)
    {
        return SetEmailAsync(user, userName, cancellationToken);
    }

    public Task<string> GetNormalizedUserNameAsync(UserDto user, CancellationToken cancellationToken)
    {
        return GetUserNameAsync(user, cancellationToken);
    }

    public Task SetNormalizedUserNameAsync(UserDto user, string normalizedName, CancellationToken cancellationToken)
    {
        return SetUserNameAsync(user, normalizedName, cancellationToken);
    }

    public async Task<IdentityResult> CreateAsync(UserDto user, CancellationToken cancellationToken)
    {
        if (user == null)
        {
            return IdentityResult.Failed();
        }

        await _userFacade.AddUserAsync(user);

        return IdentityResult.Success;
    }

    public async Task<IdentityResult> UpdateAsync(UserDto user, CancellationToken cancellationToken)
    {
        if (user == null)   
        {
            return IdentityResult.Failed();
        }

        await _userFacade.UpdateUserAsync(user.Id, user.FirstName, user.LastName, user.Email, user.Password, user.Role);

        return IdentityResult.Success;
    }

    public Task<IdentityResult> DeleteAsync(UserDto user, CancellationToken cancellationToken)
    {
        return Task.FromResult(IdentityResult.Success);
        // return ExecuteQueryAsync(() => userRepository.Delete(user?.UserId ?? 0), cancellationToken);
    }

    public async Task<UserDto> FindByIdAsync(string userId, CancellationToken cancellationToken)
    {
        var id = new Guid(userId);
        return await _userFacade.GetUserAsync(id);
    }

    public Task<UserDto> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
    {
        return FindByEmailAsync(normalizedUserName, cancellationToken);
    }

    public async Task AddToRoleAsync(UserDto user, string roleName, CancellationToken cancellationToken)
    {
        if (!Enum.TryParse<UserRole>(roleName, out var role))
        {
            return;
        }

        await _userFacade.UserChangeRoleAsync(user.Id, role);
    }

    public Task RemoveFromRoleAsync(UserDto user, string roleName, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
        // if (!Enum.TryParse<UserRole>(roleName, out var role))
        // {
        //     return Task.CompletedTask;
        // }
        //
        // var roleId = (int)role;
        //
        // return ExecuteQueryAsync(() =>
        //     {
        //         var roleEntity = userRoleRepository.Query().Where(x => x.UserId == user.UserId && x.RoleId == roleId).FirstOrDefault();
        //
        //         if (roleEntity is not null)
        //         {
        //             userRoleRepository.Delete(roleEntity.UserRoleId);
        //         }
        //     },
        //     cancellationToken);
    }

    public Task<IList<string>> GetRolesAsync(UserDto user, CancellationToken cancellationToken)
    {
        var res = new List<string> { user.Role.ToString() } as System.Collections.Generic.IList<string>;

        return Task.FromResult(res);
    }

    public async Task<bool> IsInRoleAsync(UserDto user, string roleName, CancellationToken cancellationToken)
    {
        if (!Enum.TryParse<UserRole>(roleName, out var role))
        {
            return false;
        }

        var roleId = (int)role;

        var dbUser = await _userFacade.GetUserAsync(user.Id);

        return (int)dbUser.Role == roleId;
    }

    public async Task<IList<UserDto>> GetUsersInRoleAsync(string roleName, CancellationToken cancellationToken)
    {
        if (!Enum.TryParse<UserRole>(roleName, out var role))
        {
            return Array.Empty<UserDto>() as IList<UserDto>;
        }

        return (await _userFacade.GetAllUsersAsync()).Where(x => x.Role == role).Select(x => x.Id).ToList() as IList<UserDto>;
    }

    public Task SetPasswordHashAsync(UserDto user, string passwordHash, CancellationToken cancellationToken)
    {
        if (user != null)
        {
            user.PasswordHash = passwordHash;
        }

        return Task.CompletedTask;
    }

    public Task<string> GetPasswordHashAsync(UserDto user, CancellationToken cancellationToken)
    {
        return Task.FromResult(user?.PasswordHash);
    }

    public Task<bool> HasPasswordAsync(UserDto user, CancellationToken cancellationToken)
    {
        return Task.FromResult(user?.PasswordHash?.Any() ?? false);
    }

    public Task SetEmailAsync(UserDto user, string email, CancellationToken cancellationToken)
    {
        if (user != null)
        {
            user.Email = email;
        }

        return Task.CompletedTask;
    }

    public Task<string> GetEmailAsync(UserDto user, CancellationToken cancellationToken)
    {
        return Task.FromResult(user.Email);
    }

    public Task<bool> GetEmailConfirmedAsync(UserDto user, CancellationToken cancellationToken)
    {
        return Task.FromResult(true);
    }

    public Task SetEmailConfirmedAsync(UserDto user, bool confirmed, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public async Task<UserDto> FindByEmailAsync(string normalizedEmail, CancellationToken cancellationToken)
    {
        var usr = await _userFacade.GetUserByEmailAsync(normalizedEmail);

        return usr ?? new UserDto();
    }

    public Task<string> GetNormalizedEmailAsync(UserDto user, CancellationToken cancellationToken)
    {
        return GetEmailAsync(user, cancellationToken);
    }

    public Task SetNormalizedEmailAsync(UserDto user, string normalizedEmail, CancellationToken cancellationToken)
    {
        return SetEmailAsync(user, normalizedEmail, cancellationToken);
    }

    public Task SetSecurityStampAsync(UserDto user, string stamp, CancellationToken cancellationToken)
    {
        user.SecurityStamp = stamp;

        return Task.CompletedTask;
    }

    public Task<string> GetSecurityStampAsync(UserDto user, CancellationToken cancellationToken)
    {
        return Task.FromResult(user.SecurityStamp);
    }
}