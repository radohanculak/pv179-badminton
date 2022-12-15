using Microsoft.AspNetCore.Mvc;
using Sprint.BL.Facades.Interfaces;
using Sprint.BL.Services.Interfaces;
using Sprint.Common.Enums;
using Sprint.MVC.Models.TrainerReview;
using Sprint.MVC.Models.User;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Sprint.MVC.Controllers;

public class UserController : Controller
{
    private readonly IUserFacade _userFacade;
    private readonly ICourtReservationFacade _courtResFacade;
    private readonly ITrainerFacade _trainerFacade;
    private readonly IPhotoFacade _photoFacade;

    public UserController(IUserFacade userFacade, ICourtReservationFacade courtResFacade,
        ITrainerFacade trainerFacade, IPhotoFacade photoFacade)
    {
        _userFacade = userFacade;
        _courtResFacade = courtResFacade;
        _trainerFacade = trainerFacade;
        _photoFacade = photoFacade;
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
        
        var model = new UserUpsertModel(dto.Id, dto.FirstName, dto.LastName, dto.Email, dto.Role, dto.PhotoPath);

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

        if (model.OldRole != model.Role)
        {
            if (model.Role == UserRole.Trainer)
            {
                await _trainerFacade.AddTrainerAsync(model.Id, "", 1);
            }
        }
        
        await _userFacade.UpdateUserAsync(model.Id, model.FirstName, model.LastName, model.Email, model.Password, model.Role);
        
        if (model.PhotoPath is not null)
        {
            await _photoFacade.AddProfilePhotoAsync(model.Id, model.PhotoPath);
        }
        else
        {
            await _photoFacade.DeleteProfilePhotoAsync(model.Id);
        }
        
        return RedirectToAction(nameof(Info), new {id = model.Id});
    }

    public async Task<IActionResult> Reservations(Guid id)
    {
        var dtos = await _courtResFacade.GetReservationsAsync(id, true, false);

        var model = new UserReservationsViewModel(id);
        model.Reservations = dtos;

        return View(model);
    }

    public async Task<IActionResult> Delete(Guid id)
    {
        var user = await _userFacade.GetUserAsync(id);
        if (user.Role == UserRole.Trainer)
        {
            await _trainerFacade.DeleteTrainerAsync(user.Trainer.Id);
        }
        
        await _userFacade.DeleteUserAsync(id);
        
        return RedirectToAction(nameof(Index));
    }

    /*
    public async Task<IActionResult> CancelReservation(Guid reservationId)
    {
        await _courtResFacade.DeleteReservationAsync(reservationId);
        
        return RedirectToAction(nameof(Index));
    }
    */
}