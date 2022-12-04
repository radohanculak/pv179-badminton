using Microsoft.AspNetCore.Mvc;
using Sprint.BL.Facades.Interfaces;
using Sprint.BL.Services;
using Sprint.BL.Services.Interfaces;
using Sprint.MVC.Models.Trainer;

namespace Sprint.MVC.Controllers;

public class TrainerController : Controller
{
    private readonly ITrainerFacade _trainerFacade;
    private readonly ITrainerService _trainerService;

    public TrainerController(ITrainerFacade trainerFacade, ITrainerService userFacade)
    {
        _trainerFacade = trainerFacade;
        _trainerService = userFacade;
    }
    
    [HttpGet("Trainers")]
    public async Task<IActionResult> Index()
    {
        var model = new TrainerIndexViewModel
        {
            Trainers = await _trainerService.GetAllTrainersAsync()
        };
        return View(model);
    }
    
    public async Task<IActionResult> Info(Guid id)
    {
        var dto = await _trainerService.GetTrainerAsync(id);
        if (dto == null)
        {
            return NotFound();
        }

        var model = new TrainerInfoViewModel(dto);
        return View(model);
    }

    public IActionResult Edit(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<IActionResult> InfoUser(Guid userId)
    {
        var x = (await _trainerService.GetTrainerByUserIdAsync(userId)).Id;
        return await Info(x);
    }
}