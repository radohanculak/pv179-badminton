using Ardalis.GuardClauses;
using AutoMapper;
using Sprint.BL.Dto.Trainer;
using Sprint.BL.Dto.TrainerReservation;
using Sprint.BL.Dto.User;
using Sprint.BL.Services.Interfaces;
using Sprint.DAL.EFCore.Models;
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

    public async Task<TrainerDto> AddTrainer(Guid userId, string description, decimal hourlyRate)
    {
        Guard.Against.NegativeOrZero(hourlyRate);

        var newTrainer = new TrainerCreateDto
        {
            UserId = userId,
            Description = description,
            HourlyRate = hourlyRate
        };


        var trainerId = await _unitOfWork.TrainerRepository.InsertAsync(_mapper.Map<Trainer>(newTrainer));

        await _unitOfWork.CommitAsync();

        var trainer = await _unitOfWork.TrainerRepository.GetByIdAsync(trainerId);

        return _mapper.Map<TrainerDto>(trainer);
    }
}
