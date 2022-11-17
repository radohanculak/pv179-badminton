using Sprint.BL.Dto.CourtReservation;

namespace Sprint.BL.Services.Interfaces;

public interface ICourtService
{
    Task<IEnumerable<CourtReservationDto>> GetDailySchedule(Guid courtId);
}
