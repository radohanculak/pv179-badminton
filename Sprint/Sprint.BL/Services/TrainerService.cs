using Ardalis.GuardClauses;
using AutoMapper;
using Sprint.BL.Dto.CourtReservation;
using Sprint.BL.Dto.Trainer;
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

    public async Task<TrainerDto?> GetTrainer(Guid userId)
    {
        var user = await _unitOfWork.UserRepository.GetByIdAsync(userId);

        if (user == null)
        {
            throw new InvalidOperationException($"User with id {userId} does not exist");
        }

        if (!user.IsTrainer)
        {
            throw new InvalidOperationException($"User with id {userId} is not trainer");
        }

        return _mapper.Map<TrainerDto>(user?.Trainer);
    }

    public async Task<List<CourtReservationDto>?> GetDailySchedule(Guid trainerId)
    {
        var trainer = await _unitOfWork.TrainerRepository.GetByIdAsync(trainerId);

        if (trainer == null || !trainer.Reservations.Any())
        {
            return null;
        }

        return _mapper.Map<List<CourtReservationDto>>(trainer.Reservations.Select(r => r.CourtReservation));
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
        var user = await _unitOfWork.UserRepository.GetByIdAsync(userId);

        if (user == null)
        {
            throw new InvalidOperationException($"User with id {userId} does not exist");
        }

        if (user.Role == Common.Enums.UserRole.Trainer)
        {
            throw new InvalidOperationException($"User with id {userId} is already a trainer");
        }

        user.Role = Common.Enums.UserRole.Trainer;

        _unitOfWork.UserRepository.Update(user);

        await _unitOfWork.CommitAsync();

        var trainer = await _unitOfWork.TrainerRepository.GetByIdAsync(trainerId);

        return _mapper.Map<TrainerDto>(trainer);
    }
}
