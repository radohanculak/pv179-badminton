using Ardalis.GuardClauses;
using AutoMapper;
using Sprint.BL.Dto.Court;
using Sprint.BL.Dto.CourtReservation;
using Sprint.BL.Services.Interfaces;
using Sprint.Infrastructure.UnitOfWork;

namespace Sprint.BL.Services;

public class CourtService : ICourtService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public CourtService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<CourtReservationDto>> GetDailySchedule(Guid courtId, DateTime date)
    {
        Guard.Against.Null(courtId);

        var reservations = await _unitOfWork.CourtReservationRepository.GetAllAsync();

        var selectedReservations = reservations.Where(r => r.CourtId == courtId && r.From.Date == date);

        return _mapper.Map<List<CourtReservationDto>>(selectedReservations);
    }
}
