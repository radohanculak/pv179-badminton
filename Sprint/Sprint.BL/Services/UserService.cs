using Ardalis.GuardClauses;
using AutoMapper;
using Sprint.BL.Dto.User;
using Sprint.BL.Services.Interfaces;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Identity;

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

    public async Task<UserDto> AddUserAsync(string firstName, string lastName, string email, DateTime dateOfBirth)
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
            Password = "v autentizaci budeme resit"
        };

        var userId = await _unitOfWork.UserRepository.InsertAsync(_mapper.Map<User>(newUser));
        await _unitOfWork.CommitAsync();

        return await GetUserAsync(userId);
    }

    public async Task<UserDto> GetUserAsync(Guid userId)
    {
        Guard.Against.Null(userId);

        var user = await _unitOfWork.UserRepository.GetByIdAsync(userId);

        if (user == null)
        {
            throw new InvalidOperationException($"User with id {userId} does not exist");
        }

        return _mapper.Map<UserDto>(user);
    }

    public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
    {
        var res = await _unitOfWork.UserRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<UserDto>>(res);
    }
    
    public async Task UpdateUserAsync(Guid userId, string firstName, string lastName, string email, string password)
    {
        Guard.Against.Null(userId);
        var user = await _unitOfWork.UserRepository.GetByIdAsync(userId);
        if (user == null)
        {
            throw new InvalidOperationException($"User with id {userId} does not exist");
        }

        user.FirstName = firstName;
        user.LastName = lastName;
        user.Email = email;
        user.PasswordHash = new PasswordHasher<UserDto>().HashPassword(null!, password);
        
        _unitOfWork.UserRepository.Update(user);
        await _unitOfWork.CommitAsync();
    }
}
