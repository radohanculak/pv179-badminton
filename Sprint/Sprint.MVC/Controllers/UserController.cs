using Microsoft.AspNetCore.Mvc;
using Sprint.BL.Facades.Interfaces;
using Sprint.BL.Services.Interfaces;
using SprintMVC.Models.User;

namespace SprintMVC.Controllers;

public class UserController : Controller
{
    private readonly IUserFacade _userFacade;

    public UserController(IUserFacade userFacade)
    {
        _userFacade = userFacade;
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
        var dto = await _userFacade.GetUserAsync(id);
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

        await _userFacade.UpdateUserAsync(model.Id, model.FirstName, model.LastName, model.Email, model.Password);

        return RedirectToAction(nameof(Index));
    }
}