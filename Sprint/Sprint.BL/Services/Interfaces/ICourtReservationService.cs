using Sprint.BL.Dto.CourtReservation;

namespace Sprint.BL.Services.Interfaces;

public interface ICourtReservationService
{
    Task<CourtReservationDto> AddReservation(Guid userId, Guid courtId, DateTime from, DateTime to);
    Task<List<CourtReservationDto>> GetAllReservations();
    Task<CourtReservationDto> GetReservation(Guid reservationId);
    Task<List<CourtReservationDto>> GetReservations(Guid userId, bool inPast);
    Task<List<CourtReservationDto>> GetReservations(Guid userId, DateTime from, DateTime to);
    Task DeleteReservation(Guid reservationId);
}
