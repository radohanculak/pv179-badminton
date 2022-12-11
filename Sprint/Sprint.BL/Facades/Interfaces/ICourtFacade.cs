using Sprint.BL.Dto.Court;
using Sprint.BL.Dto.CourtReservation;

namespace Sprint.BL.Facades.Interfaces;

public interface ICourtFacade
{
    Task<CourtDto> AddCourtAsync(string courtNumber, decimal hourlyRate);
    Task<CourtDto> GetCourtAsync(Guid courtId);
    Task<List<CourtDto>> GetCourtsAsync();
    Task<List<CourtDto>> GetCourtsAsync(int page, int pageSize);
    Task UpdateCourtAsync(Guid courtId, string courtNumber, decimal hourlyRate);
    Task<IEnumerable<CourtReservationDto>> GetDailyScheduleAsync(Guid courtId, DateTime date);
}
