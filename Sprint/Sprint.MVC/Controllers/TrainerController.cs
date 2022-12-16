using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sprint.BL.Facades.Interfaces;
using Sprint.MVC.Models.Trainer;
using Sprint.MVC.Models.TrainerReview;

namespace Sprint.MVC.Controllers;

[Authorize]
public class TrainerController : Controller
{
    private readonly ITrainerFacade _trainerFacade;
    private readonly ITrainerReservationFacade _trainerReservationFacade;
    private readonly ITrainerReviewFacade _trainerReviewFacade;
    private readonly IPhotoFacade _photoFacade;
    private readonly ICourtFacade _courtFacade;

    public TrainerController(ITrainerFacade trainerFacade, ITrainerReservationFacade trainerReservationFacade,
        ITrainerReviewFacade trainerReviewFacade, IPhotoFacade photoFacade, ICourtFacade courtFacade)
    {
        _trainerFacade = trainerFacade;
        _trainerReservationFacade = trainerReservationFacade;
        _trainerReviewFacade = trainerReviewFacade;
        _photoFacade = photoFacade;
        _courtFacade = courtFacade;
    }
    
    [HttpGet("Trainers")]
    [AllowAnonymous]
    public async Task<IActionResult> Index()
    {
        var model = new TrainerIndexViewModel
        {
            Trainers = await _trainerFacade.GetAllTrainersAsync()
        };

        return View(model);
    }
    
    [AllowAnonymous]
    public async Task<IActionResult> Info(Guid id)
    {
        var dto = await _trainerFacade.GetTrainerAsync(id);
        var photosDto = await _photoFacade.GetTrainerPhotosAsync(id);
        var trainerRating = await _trainerReviewFacade.GetRatingAsync(id);
        
        if (dto == null)
        {
            return NotFound();
        }

        trainerRating ??= 0;
        
        var model = new TrainerInfoViewModel(dto, photosDto, trainerRating);

        return View(model);
    }
    
    
    //[Authorize(Roles = "Admin")]
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
    //[Authorize(Roles = "Admin")]
    public async Task<IActionResult> Edit([FromForm] TrainerEditViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        await _trainerFacade.UpdateTrainerAsync(model.Id, model.Description, model.HourlyRate);

        return RedirectToAction(nameof(Info), new { id = model.Id});
    }

    [Authorize(Roles = "Admin, Trainer")]
    public async Task<IActionResult> Reservations(Guid id)
    {
        var dtos = await _trainerReservationFacade.GetReservationsForTrainerAsync(id, true, false);
        var courts = await _courtFacade.GetCourtsAsync();
        
        var model = new TrainerReservationsViewModel(id);
        model.Reservations = dtos;
        model.Courts = courts;

        return View(model);
    }
    
    public async Task<IActionResult> AddPhoto(Guid id)
    {
        var model = new TrainerPhotoAddViewModel(id);

        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AddPhoto([FromForm] TrainerPhotoAddViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        await _photoFacade.AddTrainerPhotoAsync(model.TrainerId, new List<string> { model.PhotoPath });

        return RedirectToAction(nameof(Info), new {id = model.TrainerId});
    }
    

    public async Task<IActionResult> DeletePhotos(Guid id)
    {
        await _photoFacade.DeleteTrainerPhotosAsync(id);
        
        return RedirectToAction(nameof(Info), new {id = id});
    }

    public IActionResult GetSchedule(Guid id)
    {
        var model = new TrainerScheduleViewModel(id);
        
        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> GetSchedule([FromForm] TrainerScheduleViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var schedule = await _trainerReservationFacade.GetTrainerDailyScheduleAsync(model.TrainerId, model.Date);

        byte[] bytes = Encoding.UTF8.GetBytes(schedule);
        return File(bytes, "text/plain", "schedule.xml");
    }
}