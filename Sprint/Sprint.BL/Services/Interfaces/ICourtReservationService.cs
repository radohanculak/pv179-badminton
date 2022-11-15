using Sprint.BL.Dto.CourtReservation;

namespace Sprint.BL.Services.Interfaces;

public interface ICourtReservationService
{
    Task<bool> AddReservation(CourtReservationDto reservation);
    Task<List<CourtReservationDto>> GetReservations(Guid userId, bool all);
    Task<List<CourtReservationDto>> GetReservations(Guid userId, DateTime from, DateTime to);
    Task<bool> DeleteReservation(Guid reservationId);
}
