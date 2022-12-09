using Sprint.BL.Dto.Court;
using Sprint.BL.Dto.CourtReservation;
using Sprint.BL.Facades.Interfaces;
using Sprint.BL.Services.Interfaces;

namespace Sprint.BL.Facades;

public class CourtFacade : ICourtFacade
{
    private readonly ICourtService _courtService;

    public CourtFacade(ICourtService courtService)
    {
        _courtService = courtService;
    }

    public async Task<CourtDto> AddCourtAsync(string courtNumber, decimal hourlyRate)
    {
        return await _courtService.AddCourtAsync(courtNumber, hourlyRate);
    }

    public async Task<CourtDto> GetCourtAsync(Guid courtId)
    {
        return await _courtService.GetCourtAsync(courtId);
    }

    public async Task<List<CourtDto>> GetCourtsAsync()
    {
        return await _courtService.GetCourtsAsync();
    }

    public async Task<List<CourtDto>> GetCourtsAsync(int page, int pageSize)
    {
        return await _courtService.GetCourtsAsync(page, pageSize);
    }

    public async Task<IEnumerable<CourtReservationDto>> GetDailyScheduleAsync(Guid courtId, DateTime date)
    {
        return await _courtService.GetDailyScheduleAsync(courtId, date);
    }

    public async Task UpdateCourtAsync(Guid courtId, string courtNumber, decimal hourlyRate)
    {
        await _courtService.UpdateCourtAsync(courtId, courtNumber, hourlyRate);
    }
}
