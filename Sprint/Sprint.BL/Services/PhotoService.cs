using System.Text;
using AutoMapper;
using Sprint.BL.Dto.Trainer;
using Sprint.BL.Dto.TrainerPhoto;
using Sprint.BL.Dto.User;
using Sprint.BL.Services.Interfaces;
using Sprint.Infrastructure.UnitOfWork;
using Sprint.DAL.EFCore.Models;

namespace Sprint.BL.Services;

public class PhotoService : IPhotoService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserService _userService;
    private readonly ITrainerService _trainerService;

    public PhotoService(IUnitOfWork unitOfWork, IMapper mapper, ITrainerService trainerService, IUserService userService)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _trainerService = trainerService;
        _userService = userService;
    }

    private async Task<UserDto?> GetUserAsync(Guid userId)
    {
        var user = await _unitOfWork.UserRepository.GetByIdAsync(userId);
        return _mapper.Map<UserDto?>(user);
    }

    private async Task<TrainerDto?> GetTrainerAsync(Guid trainerId)
    {
        var trainer = await _unitOfWork.TrainerRepository.GetByIdAsync(trainerId);
        return _mapper.Map<TrainerDto?>(trainer);
    }

    public async Task<bool> AddProfilePhotoAsync(Guid userId, string path)
    {
        var user = await GetUserAsync(userId);
        if (user == null)
        {
            return false;
        }

        user.PhotoPath = path;
        await _unitOfWork.UserRepository.InsertAsync(_mapper.Map<User>(user));
        await _unitOfWork.CommitAsync();
        return true;
    }

    public async Task<bool> AddTrainerPhotoAsync(Guid trainerId, List<string> paths)
    {
        var trainer = await GetTrainerAsync(trainerId);
        if (trainer == null || !paths.Any())
        {
            return false;
        }

        foreach (var path in paths)
        {
            var newPhoto = new TrainerPhotoDto
            {
                Hide = false,
                Path = path
            };
            trainer.TrainerPhotos.Add(newPhoto);
        }

        await _unitOfWork.TrainerPhotoRepository
            .InsertAsync(
                _mapper.Map<TrainerPhoto>(trainer.TrainerPhotos)
            );

        _unitOfWork.TrainerRepository.Update(_mapper.Map<Trainer>(trainer));
        await _unitOfWork.CommitAsync();

        return true;
    }

    public async Task<byte[]> GetProfilePhotoAsync(Guid userId)
    {
        var user = await GetUserAsync(userId);
        return user == null ? Array.Empty<byte>() : Encoding.ASCII.GetBytes(user.PhotoPath);
    }

    public async Task<List<byte[]>> GetTrainerPhotosAsync(Guid trainerId)
    {
        var trainer = await GetTrainerAsync(trainerId);
        if (trainer == null)
        {
            return new List<byte[]>();
        }

        return trainer.TrainerPhotos
            .Where(x => !x.Hide)
            .Select(x => x.Path)
            .Select(path => Encoding.ASCII.GetBytes(path))
            .ToList();
    }

    public async Task<bool> DeleteProfilePhotoAsync(Guid userId)
    {
        var user = await GetUserAsync(userId);
        if (user == null)
        {
            return false;
        }

        user.PhotoPath = null;
        _unitOfWork.UserRepository.Update(_mapper.Map<User>(user));
        await _unitOfWork.CommitAsync();

        return true;
    }

    public async Task<bool> DeleteTrainerPhotosAsync(Guid trainerId)
    {
        var trainer = await GetTrainerAsync(trainerId);
        if (trainer == null)
        {
            return false;
        }

        foreach (var photo in trainer.TrainerPhotos)
        {
            photo.Hide = true;
        }

        _unitOfWork.TrainerPhotoRepository.Update(
            _mapper.Map<TrainerPhoto>(trainer.TrainerPhotos)
        );
        _unitOfWork.TrainerRepository.Update(_mapper.Map<Trainer>(trainer));
        // all trainer photos should now have hidden attribute set to true
        // trainer.TrainerPhotos will still contain them, but as hidden

        await _unitOfWork.CommitAsync();
        return true;
    }
}
