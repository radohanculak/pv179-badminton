using Microsoft.AspNetCore.Mvc;
using Sprint.BL.Facades.Interfaces;
using Sprint.BL.Services.Interfaces;
using Sprint.MVC.Models.TrainerReview;
using Sprint.MVC.Models.User;

namespace Sprint.MVC.Controllers;

public class UserController : Controller
{
    private readonly IUserFacade _userFacade;
    private readonly ICourtReservationFacade _courtFacade;
    private readonly ITrainerReviewFacade _trainerReviewFacade;

    public UserController(IUserFacade userFacade, ICourtReservationFacade courtFacade,
        ITrainerReviewFacade trainerReviewFacade)
    {
        _userFacade = userFacade;
        _courtFacade = courtFacade;
        _trainerReviewFacade = trainerReviewFacade;
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
    
    public async Task<IActionResult> Info(Guid id)
    {
        var dto = await _userFacade.GetUserAsync(id);
        if (dto == null)
        {
            return NotFound();
        }

        var model = new UserInfoViewModel(dto);
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

    public async Task<IActionResult> ReviewGet(Guid trainerReservationId)
    {
        var dto = await _trainerReviewFacade.GetReviewForReservationAsync(trainerReservationId);
        if (dto == null)
        {
            return NotFound();
        }

        var model = new TrainerReviewViewModel(trainerReservationId, dto);
        return View(model);
    }
    
    /*
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> ReviewGet([FromForm] UserUpsertModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        await _userFacade.UpdateUserAsync(model.Id, model.FirstName, model.LastName, model.Email, model.Password);

        return RedirectToAction(nameof(Index));
    }
    */
    
    public async Task<IActionResult> ReviewWrite(Guid trainerReservationId)
    {
        var model = new TrainerReviewViewModel(trainerReservationId);
        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> ReviewWrite([FromForm] TrainerReviewViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        await _trainerReviewFacade.AddReviewAsync(model.TrainerReservationId, model.Review.Rating, model.Review.Text);
        
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Reservations(Guid id)
    {
        var dtos = await _courtFacade.GetReservationsAsync(id, true, false);

        var model = new UserReservationsViewModel(id);
        model.Reservations = dtos;
        return View(model);
    }
}