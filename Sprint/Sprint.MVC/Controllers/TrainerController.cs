using Microsoft.AspNetCore.Mvc;
using Sprint.BL.Facades.Interfaces;
using Sprint.MVC.Models.Trainer;
using Sprint.MVC.Models.TrainerReview;

namespace Sprint.MVC.Controllers;

public class TrainerController : Controller
{
    private readonly ITrainerFacade _trainerFacade;
    private readonly ITrainerReservationFacade _trainerReservationFacade;
    private readonly ITrainerReviewFacade _trainerReviewFacade;

    public TrainerController(ITrainerFacade trainerFacade, ITrainerReservationFacade trainerReservationFacade,
        ITrainerReviewFacade trainerReviewFacade)
    {
        _trainerFacade = trainerFacade;
        _trainerReservationFacade = trainerReservationFacade;
        _trainerReviewFacade = trainerReviewFacade;
    }
    
    [HttpGet("Trainers")]
    public async Task<IActionResult> Index()
    {
        var model = new TrainerIndexViewModel
        {
            Trainers = await _trainerFacade.GetAllTrainersAsync()
        };

        return View(model);
    }
    
    public async Task<IActionResult> Info(Guid id)
    {
        var dto = await _trainerFacade.GetTrainerAsync(id);
        if (dto == null)
        {
            return NotFound();
        }

        var model = new TrainerInfoViewModel(dto);

        return View(model);
    }
    
    public async Task<IActionResult> InfoUser(Guid userId)
    {
        var x = (await _trainerFacade.GetTrainerByUserIdAsync(userId)).Id;

        return await Info(x);
    }

    public async Task<IActionResult> Edit(Guid id)
    {
        var dto = await _trainerFacade.GetTrainerAsync(id);
        if (dto == null)
        {
            return NotFound();
        }

        var model = new TrainerEditViewModel(dto.Id, dto.Description, dto.HourlyRate);

        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit([FromForm] TrainerEditViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        await _trainerFacade.UpdateTrainerAsync(model.Id, model.Description, model.HourlyRate);

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> ReviewGet(Guid reservationId)
    {
        var dto = await _trainerReviewFacade.GetReviewForReservationAsync(reservationId);
        if (dto == null)
        {
            return NotFound();
        }
        
        var model = new TrainerReviewViewModel(reservationId, dto);

        return View(model);
    }

    public async Task<IActionResult> Reservations(Guid id)
    {
        var dtos = await _trainerReservationFacade.GetReservationsForTrainerAsync(id, true, false);

        var model = new TrainerReservationsViewModel(id);
        model.Reservations = dtos;

        return View(model);
    }
}