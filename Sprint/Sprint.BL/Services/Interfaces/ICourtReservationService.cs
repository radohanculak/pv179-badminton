using Sprint.BL.Dto.CourtReservation;
using Sprint.BL.Dto.User;

namespace Sprint.BL.Services.Interfaces;

public interface ICourtReservationService
{
    Task<CourtReservationDto> AddReservationAsync(Guid userId, Guid courtId, DateTime from, DateTime to);
    Task<List<CourtReservationDto>> GetAllReservationsAsync(bool alsoDeleted);
    Task<CourtReservationDto> GetReservationAsync(Guid reservationId);
    List<CourtReservationDto> GetReservations(UserDto user, bool inPast, bool alsoDeleted);
    List<CourtReservationDto> GetReservations(UserDto user, DateTime from, DateTime to, bool alsoDeleted);
    Task DeleteReservationAsync(Guid reservationId);
    Task<List<CourtReservationDto>> GetReservationsForDayAsync(DateTime date);
}
