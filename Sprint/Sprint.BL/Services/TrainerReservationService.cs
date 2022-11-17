using AutoMapper;
using Sprint.BL.Dto.TrainerReservation;
using Sprint.BL.Services.Interfaces;
using Sprint.Infrastructure.UnitOfWork;

namespace Sprint.BL.Services;

public class TrainerReservationService : ITrainerReservationService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public TrainerReservationService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<TrainerReservationDto> AddReservation(TrainerReservationDto trainerReservation)
    {
        throw new NotImplementedException();
    }

    public async Task<List<TrainerReservationDto>> GetReservations(Guid trainerId, bool all)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteReservation(Guid reservationId, bool keepCourtReservation)
    {
        throw new NotImplementedException();
    }
}
