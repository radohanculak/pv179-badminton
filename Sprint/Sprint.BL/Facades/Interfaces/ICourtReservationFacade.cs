using Sprint.BL.Dto.CourtReservation;

namespace Sprint.BL.Facades.Interfaces;

public interface ICourtReservationFacade
{
    Task<CourtReservationDto> AddReservationAsync(Guid userId, Guid courtId, DateTime from, DateTime to);
    Task<List<CourtReservationDto>> GetAllReservationsAsync(bool alsoDeleted);
    Task<CourtReservationDto> GetReservationAsync(Guid reservationId);
    Task<List<CourtReservationDto>> GetReservationsAsync(Guid userId, bool inPast, bool alsoDeleted);
    Task<List<CourtReservationDto>> GetReservationsAsync(Guid userId, DateTime from, DateTime to, bool alsoDeleted);
    Task DeleteReservationAsync(Guid reservationId);
    Task<List<CourtReservationDto>> GetReservationsForDayAsync(DateTime date);
}
