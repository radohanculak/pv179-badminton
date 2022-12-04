using Microsoft.AspNetCore.Mvc;
using Sprint.BL.Facades;
using Sprint.BL.Services.Interfaces;
using SprintMVC.Models.User;

namespace SprintMVC.Controllers;

public class UserController : Controller
{
    private readonly IUserFacade _userFacade;
    private readonly IUserService _userService;

    public UserController(IUserFacade userFacade, IUserService userService)
    {
        _userFacade = userFacade;
        _userService = userService;
    }

    [HttpGet("Users")]
    public async Task<IActionResult> Index()
    {
        var model = new UserIndexViewModel
        {
            Users = await _userFacade.GetAllUsersAsync()
        };
        return View(model);
    }
    
    public async Task<IActionResult> Edit(Guid id)
    {
        var dto = await _userService.GetUserAsync(id);
        if (dto == null)
        {
            return NotFound();
        }

        var model = new UserUpsertModel(dto.Id, dto.FirstName, dto.LastName, dto.Email);
        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit([FromForm] UserUpsertModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        await _userService.UpdateUserAsync(model.Id, model.FirstName, model.LastName, model.Email, model.Password);

        return RedirectToAction(nameof(Index));
    }
}