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
    
    public UserFacade(IUnitOfWork unitOfWork, IMapper mapper, IUserService userService)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _userService = userService;
    }

    public async Task<(UserDto, TrainerDto)> AddTrainerAsync(string firstName, string lastName,
        string email, DateTime dateOfBirth, string description, decimal hourlyRate)
    {
        UserService userService = new UserService(_unitOfWork, _mapper);
        var userDto = await userService.AddUserAsync(firstName, lastName, email, dateOfBirth);
        
        TrainerService trainerService = new TrainerService(_unitOfWork, _mapper, _userService);
        var trainerDto = await trainerService.AddTrainerAsync(userDto.Id, description, hourlyRate);

        return (userDto, trainerDto);
    }

    public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
    {
        return await _userService.GetAllUsersAsync();
    }
}