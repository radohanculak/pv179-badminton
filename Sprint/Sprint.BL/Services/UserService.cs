using Ardalis.GuardClauses;
using AutoMapper;
using Sprint.BL.Dto.User;
using Sprint.BL.Services.Interfaces;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Identity;
using Sprint.Common.Enums;
using Sprint.Infrastructure.Query;

namespace Sprint.BL.Services;

public class UserService : IUserService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IQueryObject<User> queryObject;

    public UserService(IUnitOfWork unitOfWork, IMapper mapper, IQueryObject<User> queryObject)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        this.queryObject = queryObject;
    }

    public async Task<UserDto> AddUserAsync(UserDto user)
    {
        Guard.Against.Null(user);
        Guard.Against.NullOrWhiteSpace(user.FirstName);
        Guard.Against.NullOrWhiteSpace(user.LastName);
        Guard.Against.InvalidFormat(user.Email, nameof(user.Email), @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        Guard.Against.Null(user.DateOfBirth);

        var userId = await _unitOfWork.UserRepository.InsertAsync(_mapper.Map<User>(user));
        await _unitOfWork.CommitAsync();
        _unitOfWork.UserRepository.ClearTracking();
        
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

        await _unitOfWork.UserRepository.Detach(userId);
        return _mapper.Map<UserDto>(user);
    }

    public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
    {
        var res = await _unitOfWork.UserRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<UserDto>>(res);
    }
    
    public async Task UpdateUserAsync(Guid userId, string firstName, string lastName, string email, string password, UserRole role)
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
        user.PasswordHash = new PasswordHasher<UserDto>().HashPassword(null, password);
        user.Role = role;
        
        _unitOfWork.UserRepository.Update(user);
        await _unitOfWork.CommitAsync();
        _unitOfWork.UserRepository.ClearTracking();
    }
    
    /// <summary>
    /// Used in authentication.
    /// </summary>
    /// <param name="email"></param>
    /// <returns>
    /// Null if user w/ given email does not exist (must not throw an exception!)
    /// </returns>
    public async Task<UserDto?> GetUserByEmailAsync(string email)
    {
        var user = (await queryObject.Filter(x => x.Email.ToUpper() == email.ToUpper())
            .ExecuteAsync()).FirstOrDefault(x => true);

        return user != null ? _mapper.Map<UserDto>(user) : null;
    }
    
    public async Task UserChangeRoleAsync(Guid userId, UserRole role)
    {
        Guard.Against.Null(userId);
        var user = await _unitOfWork.UserRepository.GetByIdAsync(userId);
        if (user == null)
        {
            throw new InvalidOperationException($"User with id {userId} does not exist");
        }

        user.Role = role;
        
        _unitOfWork.UserRepository.Update(user);

        await _unitOfWork.CommitAsync();
        _unitOfWork.UserRepository.ClearTracking();
    }

    public async Task DeleteUserAsync(Guid userId)
    {
        var user = await _unitOfWork.UserRepository.GetByIdAsync(userId);
        
        user.IsDeleted = true;
        user.Email = "deleted user";
        user.CourtReservations = null;
        
        _unitOfWork.UserRepository.Update(_mapper.Map<User>(user));
        await _unitOfWork.CommitAsync();
        _unitOfWork.UserRepository.ClearTracking();
    }
}
