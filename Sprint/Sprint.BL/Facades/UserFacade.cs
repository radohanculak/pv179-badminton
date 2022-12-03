using AutoMapper;
using Sprint.BL.Dto.Trainer;
using Sprint.BL.Dto.User;
using Sprint.BL.Services;
using Sprint.BL.Services.Interfaces;
using Sprint.Infrastructure.UnitOfWork;

namespace Sprint.BL.Facades;

public class UserFacade : IUserFacade
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserService _userService;
    private readonly ITrainerService _trainerService;
    
    public UserFacade(IUnitOfWork unitOfWork, IMapper mapper, IUserService userService,
        ITrainerService trainerService)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _userService = userService;
        _trainerService = trainerService;
    }

    public async Task<(UserDto, TrainerDto)> AddTrainerAsync(string firstName, string lastName,
        string email, DateTime dateOfBirth, string description, decimal hourlyRate)
    {
        var userDto = await _userService.AddUserAsync(firstName, lastName, email, dateOfBirth);
        
        var trainerDto = await _trainerService.AddTrainerAsync(userDto.Id, description, hourlyRate);

        return (userDto, trainerDto);
    }

    public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
    {
        return await _userService.GetAllUsersAsync();
    }
}