using AutoMapper;
using Sprint.BL.Dto.CourtReservation;
using Sprint.BL.Services.Interfaces;
using Sprint.Infrastructure.UnitOfWork;

namespace Sprint.BL.Services;

public class CourtReservationService : ICourtReservationService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public CourtReservationService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<bool> AddReservation(CourtReservationDto reservation)
    {
        throw new NotImplementedException();
    }

    public async Task<List<CourtReservationDto>> GetReservations(Guid userId, bool all)
    {
        throw new NotImplementedException();
    }

    public async Task<List<CourtReservationDto>> GetReservations(Guid userId, DateTime from, DateTime to)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteReservation(Guid reservationId)
    {
        throw new NotImplementedException();
    }
}
