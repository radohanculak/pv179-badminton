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
    private readonly IUserService _userService;

    public TrainerService(IUnitOfWork unitOfWork, IMapper mapper, IUserService userService)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _userService = userService;
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

    public async Task<TrainerDto> GetTrainerByUserIdAsync(Guid userId)
    {
        var user = await _userService.GetUserAsync(userId);

        if (user.Role != Common.Enums.UserRole.Trainer)
        {
            throw new InvalidOperationException($"User with id {userId} is not trainer");
        }

        return _mapper.Map<TrainerDto>(user?.Trainer);
    }
}
