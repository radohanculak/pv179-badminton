using Microsoft.AspNetCore.Mvc;
using Sprint.BL.Facades.Interfaces;
using Sprint.MVC.Models.TrainerReview;

namespace Sprint.MVC.Controllers;

public class TrainerReviewController : Controller
{
    private readonly ITrainerReviewFacade _trainerReviewFacade;

    public TrainerReviewController(ITrainerReviewFacade trainerReviewFacade)
    {
        _trainerReviewFacade = trainerReviewFacade;
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
        
        return RedirectToAction(nameof(ReviewGet), new { trainerReservationId = model.TrainerReservationId });
    }
}