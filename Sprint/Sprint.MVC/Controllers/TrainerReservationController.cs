using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sprint.BL.Facades.Interfaces;
using Sprint.MVC.Models.TrainerReservation;

namespace Sprint.MVC.Controllers;

[Authorize]
public class TrainerReservationController : Controller
{
    private readonly ITrainerReservationFacade _trainerReservationFacade;
    private readonly IAvailableTrainersFacade _availableTrainersFacade;

    public TrainerReservationController(ITrainerReservationFacade trainerReservationFacade, IAvailableTrainersFacade availableTrainersFacade)
    {
        _trainerReservationFacade = trainerReservationFacade;
        _availableTrainersFacade = availableTrainersFacade;
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> ChooseTrainer(TrainerReservationCreateModel model)
    {
        var trainers = await _availableTrainersFacade.GetAllAvailableTrainers(model.TimeFrom, model.MinRating, model.MinPrice, model.MaxPrice);

        model.TrainerDtos = trainers;

        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> ConfirmReservation(TrainerReservationCreateModel model)
    {
        await _trainerReservationFacade.AddReservationAsync(model.CourtResId, model.TrainerId);

        return RedirectToAction("Index", "CourtReservation");
    }
}
