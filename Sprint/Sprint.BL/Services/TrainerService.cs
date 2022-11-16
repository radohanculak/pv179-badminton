using AutoMapper;
using Sprint.BL.Dto.Trainer;
using Sprint.BL.Dto.TrainerReservation;
using Sprint.BL.Services.Interfaces;
using Sprint.Infrastructure.UnitOfWork;


namespace Sprint.BL.Services;

public class TrainerService : ITrainerService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public TrainerService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<TrainerDto> GetTrainer(Guid user)
    {
        throw new NotImplementedException();
    }

    public async Task<List<TrainerReservationDto>> GetDailySchedule(Guid trainerId)
    {
        throw new NotImplementedException();
    }
}
