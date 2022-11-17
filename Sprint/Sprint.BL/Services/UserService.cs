using Ardalis.GuardClauses;
using AutoMapper;
using Sprint.BL.Dto.User;
using Sprint.BL.Services.Interfaces;
using Sprint.DAL.EFCore.Models;
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

    public async Task<bool> ChangePassword(Guid userId, string hash)
    {
        throw new NotImplementedException();
    }

    public async Task<UserDto> GetUser(Guid userId)
    {
        throw new NotImplementedException();
    }

    public async Task<UserDto> AddUser(string firstName, string lastName, string email, DateTime dateOfBirth)
    {
        Guard.Against.NullOrWhiteSpace(firstName);
        Guard.Against.NullOrWhiteSpace(lastName);
        Guard.Against.InvalidFormat(email, nameof(email), @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        Guard.Against.Null(dateOfBirth);

        var newUser = new UserCreateDto
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            DateOfBirth = dateOfBirth,
            Password = "v autentizaci budeme resit",
            PhotoPath = "musi byt nullable"
        };


        var userId = await _unitOfWork.UserRepository.InsertAsync(_mapper.Map<User>(newUser));

        await _unitOfWork.CommitAsync();

        var user = await _unitOfWork.UserRepository.GetByIdAsync(userId);

        return _mapper.Map<UserDto>(user);
    }
}
