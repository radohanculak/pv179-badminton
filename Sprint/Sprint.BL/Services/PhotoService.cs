using AutoMapper;
using Sprint.BL.Dto.TrainerPhoto;
using Sprint.BL.Services.Interfaces;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.UnitOfWork;
using System.Text;

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

    public async Task AddProfilePhotoAsync(Guid userId, string path)
    {
        var user = await _userService.GetUserAsync(userId);

        user.PhotoPath = path;
        _unitOfWork.UserRepository.Update(_mapper.Map<User>(user));
        await _unitOfWork.CommitAsync();
    }

    public async Task<bool> AddTrainerPhotoAsync(Guid trainerId, List<string> paths)
    {
        var trainer = await _trainerService.GetTrainerAsync(trainerId);
        if (!paths.Any())
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
        var user = await _userService.GetUserAsync(userId);

        return user?.PhotoPath == null ? Array.Empty<byte>() : Encoding.ASCII.GetBytes(user.PhotoPath);
    }

    public async Task<List<byte[]>> GetTrainerPhotosAsync(Guid trainerId)
    {
        var trainer = await _trainerService.GetTrainerAsync(trainerId);

        return trainer.TrainerPhotos
            .Where(x => !x.Hide)
            .Select(x => x.Path)
            .Select(path => Encoding.ASCII.GetBytes(path))
            .ToList();
    }

    public async Task DeleteProfilePhotoAsync(Guid userId)
    {
        var user = await _userService.GetUserAsync(userId);

        user.PhotoPath = null;
        _unitOfWork.UserRepository.Update(_mapper.Map<User>(user));
        await _unitOfWork.CommitAsync();
    }

    public async Task DeleteTrainerPhotosAsync(Guid trainerId)
    {
        var trainer = await _trainerService.GetTrainerAsync(trainerId);

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
    }
}
