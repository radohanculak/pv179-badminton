using Sprint.BL.Dto.Court;
using Sprint.BL.Dto.CourtReservation;

namespace Sprint.BL.Services.Interfaces;

public interface ICourtService
{
    Task<CourtDto> AddCourtAsync(string courtNumber, decimal hourlyRate);
    Task<CourtDto> GetCourtAsync(Guid courtId);
    Task<IEnumerable<CourtReservationDto>> GetDailyScheduleAsync(Guid courtId, DateTime date);
}
