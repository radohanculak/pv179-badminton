using Sprint.BL.Dto.CourtReservation;
using Sprint.BL.Facades.Interfaces;
using Sprint.BL.Services.Interfaces;

namespace Sprint.BL.Facades;

public class CourtReservationFacade : ICourtReservationFacade
{
    private readonly ICourtReservationService _courtReservationService;
    private readonly IUserService _userService;
    private readonly ICourtService _courtService;

    public CourtReservationFacade(ICourtReservationService courtReservationService,
        IUserService userService, ICourtService courtService)
    {
        _courtReservationService = courtReservationService;
        _userService = userService;
        _courtService = courtService;
    }

    public async Task<CourtReservationDto> AddReservationAsync(Guid userId, Guid courtId, DateTime from, DateTime to)
    {
        // controls if court and user exists - if not throws exception
        _ = await _userService.GetUserAsync(userId);
        _ = await _courtService.GetCourtAsync(courtId);

        return await _courtReservationService.AddReservationAsync(userId, courtId, from, to);
    }

    public async Task DeleteReservationAsync(Guid reservationId)
    {
        await _courtReservationService.DeleteReservationAsync(reservationId);
    }

    public async Task<List<CourtReservationDto>> GetAllReservationsAsync()
    {
        return await _courtReservationService.GetAllReservationsAsync();
    }

    public async Task<CourtReservationDto> GetReservationAsync(Guid reservationId)
    {
        return await _courtReservationService.GetReservationAsync(reservationId);
    }

    public async Task<List<CourtReservationDto>> GetReservationsAsync(Guid userId, bool inPast)
    {
        var user = await _userService.GetUserAsync(userId);

        return _courtReservationService.GetReservations(user, inPast);
    }

    public async Task<List<CourtReservationDto>> GetReservationsAsync(Guid userId, DateTime from, DateTime to)
    {
        var user = await _userService.GetUserAsync(userId);

        return _courtReservationService.GetReservations(user, from, to);
    }
}
