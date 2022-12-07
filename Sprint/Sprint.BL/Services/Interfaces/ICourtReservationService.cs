using Sprint.BL.Dto.CourtReservation;
using Sprint.BL.Dto.User;

namespace Sprint.BL.Services.Interfaces;

public interface ICourtReservationService
{
    Task<CourtReservationDto> AddReservationAsync(Guid userId, Guid courtId, DateTime from, DateTime to);
    Task<List<CourtReservationDto>> GetAllReservationsAsync();
    Task<CourtReservationDto> GetReservationAsync(Guid reservationId);
    List<CourtReservationDto> GetReservations(UserDto user, bool inPast);
    List<CourtReservationDto> GetReservations(UserDto user, DateTime from, DateTime to);
    Task DeleteReservationAsync(Guid reservationId);
}
