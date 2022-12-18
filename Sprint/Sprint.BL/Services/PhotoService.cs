using AutoMapper;
using Sprint.BL.Dto.Trainer;
using Sprint.BL.Dto.TrainerPhoto;
using Sprint.BL.Dto.User;
using Sprint.BL.Services.Interfaces;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.UnitOfWork;

namespace Sprint.BL.Services;

public class PhotoService : IPhotoService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public PhotoService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task AddProfilePhotoAsync(UserDto user, string path)
    {
        user.PhotoPath = path;

        _unitOfWork.UserRepository.Update(_mapper.Map<User>(user));
        await _unitOfWork.CommitAsync();
        _unitOfWork.UserRepository.ClearTracking();
    }

    public async Task<bool> AddTrainerPhotosAsync(TrainerDto trainer, List<string> paths)
    {
        if (!paths.Any())
        {
            return false;
        }

        foreach (var path in paths)
        {
            var newPhoto = new TrainerPhotoDto
            {
                Hide = false,
                Path = path,
                TrainerId = trainer.Id,
            };
            await _unitOfWork.TrainerPhotoRepository
                .InsertAsync(_mapper.Map<TrainerPhoto>(newPhoto));
            
            trainer.Photos.Add(newPhoto);
        }
        
        await _unitOfWork.CommitAsync();
        _unitOfWork.TrainerPhotoRepository.ClearTracking();

        return true;
    }

    public string GetProfilePhoto(UserDto user)
    {
        return user.PhotoPath ?? "";
    }

    public List<string> GetTrainerPhotos(TrainerDto trainer)
    {
        return trainer.Photos
            .Where(x => !x.Hide)
            .Select(x => x.Path)
            .ToList();
    }

    public async Task DeleteProfilePhotoAsync(UserDto user)
    {
        user.PhotoPath = null;

        _unitOfWork.UserRepository.Update(_mapper.Map<User>(user));
        await _unitOfWork.CommitAsync();
        _unitOfWork.UserRepository.ClearTracking();
    }

    public async Task DeleteTrainerPhotosAsync(TrainerDto trainer)
    {
        foreach (var photo in trainer.Photos)
        {
            photo.Hide = true;
            _unitOfWork.TrainerPhotoRepository.Update(
                _mapper.Map<TrainerPhoto>(photo)
            );
        }
        
        // all trainer photos should now have hidden attribute set to true
        // trainer.TrainerPhotos will still contain them, but as hidden

        await _unitOfWork.CommitAsync();
        _unitOfWork.TrainerPhotoRepository.ClearTracking();
    }
}
