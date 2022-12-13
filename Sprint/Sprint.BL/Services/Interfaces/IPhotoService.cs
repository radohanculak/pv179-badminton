using Sprint.BL.Dto.Trainer;
using Sprint.BL.Dto.User;

namespace Sprint.BL.Services.Interfaces;

public interface IPhotoService
{
    Task AddProfilePhotoAsync(UserDto user, string path);
    Task<bool> AddTrainerPhotosAsync(TrainerDto trainer, List<string> paths);
    string GetProfilePhoto(UserDto user);
    List<string> GetTrainerPhotos(TrainerDto trainer);
    Task DeleteProfilePhotoAsync(UserDto user);
    Task DeleteTrainerPhotosAsync(TrainerDto trainer);
}
