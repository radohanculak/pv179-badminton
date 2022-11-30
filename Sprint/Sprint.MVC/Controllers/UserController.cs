using Microsoft.AspNetCore.Mvc;
using Sprint.BL.Facades;
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
}