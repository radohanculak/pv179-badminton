using Ardalis.GuardClauses;
using AutoMapper;
using Sprint.BL.Dto.CourtReservation;
using Sprint.BL.Dto.Trainer;
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

    public async Task<TrainerDto> AddTrainerAsync(Guid userId, string description, decimal hourlyRate)
    {
        Guard.Against.NegativeOrZero(hourlyRate);

        var user = await _unitOfWork.UserRepository.GetByIdAsync(userId);

        if (user == null)
        {
            throw new InvalidOperationException($"User with id {userId} does not exist");
        }

        if (user.Role == Common.Enums.UserRole.Trainer)
        {
            throw new InvalidOperationException($"User with id {userId} is already a trainer");
        }

        var newTrainer = new TrainerCreateDto
        {
            UserId = userId,
            Description = description,
            HourlyRate = hourlyRate
        };

        user.Role = Common.Enums.UserRole.Trainer;

        var trainerId = await _unitOfWork.TrainerRepository.InsertAsync(_mapper.Map<Trainer>(newTrainer));
        _unitOfWork.UserRepository.Update(user);

        await _unitOfWork.CommitAsync();
        await _unitOfWork.UserRepository.Detach(userId);
        await _unitOfWork.TrainerRepository.Detach(trainerId);

        return await GetTrainerAsync(trainerId);
    }

    public async Task<TrainerDto> GetTrainerAsync(Guid trainerId)
    {
        var trainer = await _unitOfWork.TrainerRepository.GetByIdAsync(trainerId);

        if (trainer == null)
        {
            throw new InvalidOperationException($"Trainer with id {trainerId} does not exist");
        }

        return _mapper.Map<TrainerDto>(trainer);
    }

    public TrainerDto GetTrainerByUser(UserDto user)
    {
        if (user.Role != Common.Enums.UserRole.Trainer)
        {
            throw new InvalidOperationException($"User with id {user.Id} is not trainer");
        }

        return user.Trainer;
    }

    public async Task<IEnumerable<TrainerDto>> GetAllTrainersAsync()
    {
        var res = await _unitOfWork.TrainerRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<TrainerDto>>(res);
    }
    
    public async Task UpdateTrainerAsync(Guid trainerId, string description, decimal hourlyRate)
    {
        Guard.Against.Null(trainerId);

        var trainer = await _unitOfWork.TrainerRepository.GetByIdAsync(trainerId);
        if (trainer == null)
        {
            throw new InvalidOperationException($"Trainer with id {trainer} does not exist");
        }

        trainer.Description = description;
        trainer.HourlyRate = hourlyRate;
        
        _unitOfWork.TrainerRepository.Update(trainer);
        await _unitOfWork.CommitAsync();
        await _unitOfWork.TrainerRepository.Detach(trainerId);
    }

    public async Task DeleteTrainerAsync(Guid trainerId)
    {
        var trainer = await GetTrainerAsync(trainerId);

        trainer.IsDeleted = true;

        _unitOfWork.TrainerRepository.Update(_mapper.Map<Trainer>(trainer));
        await _unitOfWork.CommitAsync();
        await _unitOfWork.TrainerRepository.Detach(trainerId);
    }
}
