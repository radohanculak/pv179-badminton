using AutoMapper;
using Sprint.BL.Dto.User;
using Sprint.BL.Services.Interfaces;
using Sprint.Infrastructure.UnitOfWork;


namespace Sprint.BL.Services;

public class UserService : IUserService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public UserService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<UserDto> Register(UserCreateDto user)
    {
        throw new NotImplementedException();
    }

    public async Task<UserDto> Login(UserCreateDto user)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Logout(UserCreateDto user)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> ChangePassword(Guid user, string hash)
    {
        throw new NotImplementedException();
    }

    public async Task<UserDto> GetUser(Guid user)
    {
        throw new NotImplementedException();
    }
}
