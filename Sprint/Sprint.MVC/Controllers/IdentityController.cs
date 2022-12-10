using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sprint.BL.Dto.User;
using Sprint.Common.Enums;
using LoginModel = SprintMVC.Models.Identity.LoginModel;
using RegisterModel = SprintMVC.Models.Identity.RegisterModel;

namespace RepositoryIdentity.Controllers;

public class IdentityController : Controller
{
    private readonly SignInManager<UserDto> _signInManager;
    private readonly ILogger _logger;
    private readonly UserManager<UserDto> _userManager;

    public IdentityController(SignInManager<UserDto> signInManager,
        ILogger<IdentityController> logger,
        UserManager<UserDto> userManager) : base()
    {
        _signInManager = signInManager;
        _logger = logger;
        _userManager = userManager;
    }

    public IActionResult Register()
    {
        return View(new RegisterModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Register(RegisterModel model)
    {
        model.ReturnUrl ??= Url.Content("~/");

        if (ModelState.IsValid)
        {
            var newUser = new UserDto
            {
                // Id = default,
                FirstName = model.FirstName!,
                LastName = model.LastName!,
                Email = model.Email!,
                Age = 0,
                Password = model.Password!,
                PhotoPath = null,
                Trainer = null,
                CourtReservations = null,
                Role = UserRole.User,
                SecurityStamp = "",
                DateOfBirth = model.DateOfBirth ?? DateTime.MinValue,
                PasswordHash = null,
            };

            var createResult = await _userManager.CreateAsync(newUser, model.Password).ConfigureAwait(false);

            if (createResult.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(model.Email).ConfigureAwait(false);
                _logger.LogInformation($"Successfuly created a new user account: {model.Email}");

                await _userManager.AddToRoleAsync(user, "User").ConfigureAwait(false);
                if (model.Role == UserRole.Admin)
                {
                    await _userManager.AddToRoleAsync(user, "Admin").ConfigureAwait(false);
                }

                await _signInManager.SignInAsync(user, true).ConfigureAwait(false);

                return Redirect(model.ReturnUrl);
            }
        }

        if (!ModelState.IsValid)
        {
            ModelState.TryAddModelError("UserCreation", "There was an error while creating the user");
        }

        return View(model);
    }

    public IActionResult Login(string? returnUrl = "~/")
    {
        if (User.Identity?.Name is not null)
        {
            return Redirect(returnUrl!);
        }

        var viewModel = new LoginModel();
        viewModel.ReturnUrl = returnUrl;

        return View(viewModel);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(LoginModel model)
    {
        model.ReturnUrl ??= Url.Content("~/");

        if (ModelState.IsValid)
        {
            var user = await _userManager.FindByNameAsync(model.Email).ConfigureAwait(false);

            if (user is null || await _userManager.CheckPasswordAsync(user, model.Password).ConfigureAwait(false) ==
                false)
            {
                ModelState.AddModelError("message", "Invalid credentials");
                return View(model);
            }

            await _signInManager.SignOutAsync().ConfigureAwait(false);
            var loggedIn = await _signInManager.PasswordSignInAsync(model.Email, model.Password, true, false)
                .ConfigureAwait(false);

            if (loggedIn.Succeeded)
            {
                return Redirect(model.ReturnUrl);
            }
            else
            {
                // This is not really the case, but we do not want the user to know the specifics of the error
                ModelState.TryAddModelError("message", "Invalid credentials");
                _logger.LogWarning($"Error logging in user {model.Email}.");
                return View(model);
            }
        }

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Logout(string returnUrl)
    {
        await _signInManager.SignOutAsync().ConfigureAwait(false);

        return Redirect(returnUrl);
    }
}
