using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sprint.BL.Facades.Interfaces;
using Sprint.MVC.Models.CourtReservation;

namespace Sprint.MVC.Controllers;

[Authorize]
public class CourtReservationController : Controller
{
    private readonly ICourtReservationFacade _courtReservationFacade;
    private readonly ICourtFacade _courtFacade;

    public CourtReservationController(ICourtReservationFacade courtReservationFacade, ICourtFacade courtFacade)
    {
        _courtReservationFacade = courtReservationFacade;
        _courtFacade = courtFacade;
    }
    
    [HttpGet("CourtReservations")]
    public async Task<IActionResult> Index()
    {
        var model = new CourtReservationIndexViewModel
        {
            CourtReservations = await _courtReservationFacade.GetAllReservationsAsync(alsoDeleted: false)
        };

        model.Courts = await _courtFacade.GetCourtsAsync();
        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    [Authorize(Roles = "Admin, Trainer")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var reservation = await _courtReservationFacade.GetReservationAsync(id);
        if (reservation == null)
        {
            return NotFound();
        }
        await _courtReservationFacade.DeleteReservationAsync(id);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Add()
    {
        return View(new CourtReservationCreate());
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Add(CourtReservationCreate createEntity)
    {
        // invalid date, return back
        if (createEntity.Date <= DateTime.Now.Date)
        {
            return RedirectToAction(nameof(Add));
        }

        var reservations = await _courtReservationFacade.GetReservationsForDayAsync(createEntity.Date);
        var courts = (await _courtFacade.GetCourtsAsync()).OrderBy(x => x.CourtNumber).ToList();
        createEntity.CourtReservationDtos = reservations;
        createEntity.CourtDtos = courts;

        return View("ChooseCourt", createEntity);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> ConfirmReservation(CourtReservationCreate createEntity)
    {
        var usrId = Guid.Parse(User.Claims.Single(x => x.Value.Length == 36).Value);
        var res = await _courtReservationFacade.AddReservationAsync(usrId, createEntity.CourtId,
            createEntity.TimeFrom, createEntity.TimeTo);
        
        return RedirectToAction(nameof(Index));
    }
}
