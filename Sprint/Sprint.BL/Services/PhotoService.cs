using AutoMapper;
using Sprint.BL.Dto.Trainer;
using Sprint.BL.Dto.TrainerPhoto;
using Sprint.BL.Dto.User;
using Sprint.BL.Services.Interfaces;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.UnitOfWork;
using System.Text;

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
        await _unitOfWork.UserRepository.Detach(user.Id);
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
            trainer.Photos.Add(newPhoto);
        }

        await _unitOfWork.TrainerPhotoRepository
            .InsertAsync(
                _mapper.Map<TrainerPhoto>(trainer.Photos)
            );

        _unitOfWork.TrainerRepository.Update(_mapper.Map<Trainer>(trainer));
        await _unitOfWork.CommitAsync();
        //await _unitOfWork.TrainerPhotoRepository.Detach();
        await _unitOfWork.TrainerRepository.Detach(trainer.Id);

        return true;
    }

    public byte[] GetProfilePhoto(UserDto user)
    {
        return user?.PhotoPath == null ? Array.Empty<byte>() : Encoding.ASCII.GetBytes(user.PhotoPath);
    }

    public List<byte[]> GetTrainerPhotos(TrainerDto trainer)
    {
        return trainer.Photos
            .Where(x => !x.Hide)
            .Select(x => x.Path)
            .Select(path => Encoding.ASCII.GetBytes(path))
            .ToList();
    }

    public async Task DeleteProfilePhotoAsync(UserDto user)
    {
        user.PhotoPath = null;

        _unitOfWork.UserRepository.Update(_mapper.Map<User>(user));
        await _unitOfWork.CommitAsync();
    }

    public async Task DeleteTrainerPhotosAsync(TrainerDto trainer)
    {
        foreach (var photo in trainer.Photos)
        {
            photo.Hide = true;
        }

        _unitOfWork.TrainerPhotoRepository.Update(
            _mapper.Map<TrainerPhoto>(trainer.Photos)
        );
        _unitOfWork.TrainerRepository.Update(_mapper.Map<Trainer>(trainer));
        // all trainer photos should now have hidden attribute set to true
        // trainer.TrainerPhotos will still contain them, but as hidden

        await _unitOfWork.CommitAsync();
    }
}
