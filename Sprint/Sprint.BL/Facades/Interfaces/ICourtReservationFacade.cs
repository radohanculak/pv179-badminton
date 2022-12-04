using Sprint.BL.Dto.CourtReservation;

namespace Sprint.BL.Facades.Interfaces;

public interface ICourtReservationFacade
{
    Task<CourtReservationDto> AddReservationAsync(Guid userId, Guid courtId, DateTime from, DateTime to);
    Task<List<CourtReservationDto>> GetAllReservationsAsync();
    Task<CourtReservationDto> GetReservationAsync(Guid reservationId);
    Task<List<CourtReservationDto>> GetReservationsAsync(Guid userId, bool inPast);
    Task<List<CourtReservationDto>> GetReservationsAsync(Guid userId, DateTime from, DateTime to);
    Task DeleteReservationAsync(Guid reservationId);
}
