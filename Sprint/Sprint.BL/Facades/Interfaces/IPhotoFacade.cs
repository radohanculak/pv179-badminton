namespace Sprint.BL.Facades.Interfaces;

public interface IPhotoFacade
{
    Task AddProfilePhotoAsync(Guid userId, string path);
    Task<bool> AddTrainerPhotoAsync(Guid trainerId, List<string> paths);
    Task<string> GetProfilePhotoAsync(Guid userId);
    Task<List<string>> GetTrainerPhotosAsync(Guid trainerId);
    Task DeleteProfilePhotoAsync(Guid userId);
    Task DeleteTrainerPhotosAsync(Guid trainerId);
}
