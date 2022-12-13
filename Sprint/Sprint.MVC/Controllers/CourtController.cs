using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sprint.BL.Facades.Interfaces;
using Sprint.MVC.Models.Court;

namespace Sprint.MVC.Controllers;

[Authorize]
public class CourtController : Controller
{
    private readonly ICourtFacade _courtFacade;

    public CourtController(ICourtFacade courtFacade)
    {
        _courtFacade = courtFacade;
    }

    [AllowAnonymous]
    public async Task<IActionResult> Index()
    {
        var model = new CourtIndexViewModel
        {
            Courts = await _courtFacade.GetCourtsAsync()
        };

        return View(model);
    }

    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Edit(Guid id)
    {
        var dto = await _courtFacade.GetCourtAsync(id);
        if (dto == null)
        {
            return NotFound();
        }

        var model = new CourtEditViewModel(dto.Id, dto.CourtNumber, dto.HourlyRate);

        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Edit([FromForm] CourtEditViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        await _courtFacade.UpdateCourtAsync(model.Id, model.CourtNumber, model.HourlyRate);

        return RedirectToAction(nameof(Index));
    }

    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Create()
    {
        var model = new CourtEditViewModel();

        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Create([FromForm] CourtEditViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        await _courtFacade.AddCourtAsync(model.CourtNumber, model.HourlyRate);

        return RedirectToAction(nameof(Index));
    }
}
