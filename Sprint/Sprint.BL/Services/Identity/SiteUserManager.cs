using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Sprint.BL.Dto.User;

namespace Sprint.BL.Services.Identity;

public class SiteUserManager : UserManager<UserDto>
{
    private readonly IUserStore<UserDto> store;

    public SiteUserManager(
        IUserStore<UserDto> store,
        IOptions<IdentityOptions> optionsAccessor,
        IPasswordHasher<UserDto> passwordHasher,
        IEnumerable<IUserValidator<UserDto>> userValidators,
        IEnumerable<IPasswordValidator<UserDto>> passwordValidators,
        ILookupNormalizer keyNormalizer,
        IdentityErrorDescriber errors,
        IServiceProvider services,
        ILogger<UserManager<UserDto>> logger
    )
        : base(
            store,
            optionsAccessor,
            passwordHasher,
            userValidators,
            passwordValidators,
            keyNormalizer,
            errors,
            services,
            logger
        )
    {
        this.store = store;
    }

    // public override string NormalizeEmail(string email)
    // {
    //     return base.NormalizeEmail(email).ToLowerInvariant();
    // }

    public override async Task<IdentityResult> AddToRoleAsync(UserDto user, string role)
    {
        if (store is not IUserRoleStore<UserDto> roleStore)
        {
            return await base.AddToRoleAsync(user, role).ConfigureAwait(false);
        }

        try
        {
            await roleStore.AddToRoleAsync(user, role, CancellationToken);
            return IdentityResult.Success;
        }
        catch
        {
            return IdentityResult.Failed();
        }
    }

    public override async Task<IdentityResult> RemoveFromRoleAsync(UserDto user, string role)
    {
        if (store is not IUserRoleStore<UserDto> roleStore)
        {
            return await base.RemoveFromRoleAsync(user, role).ConfigureAwait(false);
        }

        try
        {
            await roleStore.RemoveFromRoleAsync(user, role, CancellationToken);
            return IdentityResult.Success;
        }
        catch
        {
            return IdentityResult.Failed();
        }
    }

    public override async Task<IdentityResult> AddToRolesAsync(UserDto user, IEnumerable<string> roles)
    {
        if (store is not IUserRoleStore<UserDto> roleStore)
        {
            return await base.AddToRolesAsync(user, roles).ConfigureAwait(false);
        }

        try
        {
            foreach (var role in roles)
            {
                await roleStore.AddToRoleAsync(user, role, CancellationToken);
            }

            return IdentityResult.Success;
        }
        catch
        {
            return IdentityResult.Failed();
        }
    }

    public override async Task<IdentityResult> RemoveFromRolesAsync(UserDto user, IEnumerable<string> roles)
    {
        if (store is not IUserRoleStore<UserDto> roleStore)
        {
            return await base.RemoveFromRolesAsync(user, roles).ConfigureAwait(false);
        }

        try
        {
            foreach (var role in roles)
            {
                await roleStore.RemoveFromRoleAsync(user, role, CancellationToken);
            }

            return IdentityResult.Success;
        }
        catch
        {
            return IdentityResult.Failed();
        }
    }
}
