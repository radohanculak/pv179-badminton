using Microsoft.AspNetCore.Identity;
using Sprint.BL.Dto.Role;
using Sprint.Common.Enums;

namespace Sprint.BL.Services.Identity;

public class RepositoryRoleStore : IRoleStore<UserRoleDto>
{
    public void Dispose()
    {
    }

    public Task<IdentityResult> CreateAsync(UserRoleDto role, CancellationToken cancellationToken)
    {
        return Task.FromResult(IdentityResult.Failed());
    }

    public Task<IdentityResult> UpdateAsync(UserRoleDto role, CancellationToken cancellationToken)
    {
        return Task.FromResult(IdentityResult.Failed());
    }

    public Task<IdentityResult> DeleteAsync(UserRoleDto role, CancellationToken cancellationToken)
    {
        return Task.FromResult(IdentityResult.Failed());
    }

    public Task<string> GetRoleIdAsync(UserRoleDto role, CancellationToken cancellationToken)
    {
        return Task.FromResult(((int)role.Role).ToString());
    }

    public Task<string> GetRoleNameAsync(UserRoleDto role, CancellationToken cancellationToken)
    {
        return Task.FromResult(role.Role.ToString());
    }

    public Task SetRoleNameAsync(UserRoleDto role, string roleName, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public Task<string> GetNormalizedRoleNameAsync(UserRoleDto role, CancellationToken cancellationToken)
    {
        return Task.FromResult(role.Role.ToString());
    }

    public Task SetNormalizedRoleNameAsync(UserRoleDto role, string normalizedName, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public Task<UserRoleDto> FindByIdAsync(string roleId, CancellationToken cancellationToken)
    {
        if (!int.TryParse(roleId, out var id))
        {
            return Task.FromResult<UserRoleDto>((UserRole)0);
        }

        return Task.FromResult<UserRoleDto>((UserRole)id);
    }

    public Task<UserRoleDto> FindByNameAsync(string normalizedRoleName, CancellationToken cancellationToken)
    {
        if (!Enum.TryParse<UserRole>(normalizedRoleName, out var role))
        {
            return Task.FromResult<UserRoleDto>((UserRole)0);
        }

        return Task.FromResult<UserRoleDto>(role);
    }
}