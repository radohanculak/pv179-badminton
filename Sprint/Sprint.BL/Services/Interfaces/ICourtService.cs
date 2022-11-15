using Sprint.DAL.EFCore.Models;

namespace Sprint.BL.Services.Interfaces;

public interface ICourtService
{
    Task<IEnumerable<CourtReservation>> GetDailySchedule(Guid court);
}
