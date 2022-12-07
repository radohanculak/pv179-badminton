namespace Sprint.BL.Facades.Interfaces;

public interface IPhotoFacade
{
    Task AddProfilePhotoAsync(Guid userId, string path);
    Task<bool> AddTrainerPhotoAsync(Guid trainerId, List<string> paths);
    Task<byte[]> GetProfilePhotoAsync(Guid userId);
    Task<List<byte[]>> GetTrainerPhotosAsync(Guid trainerId);
    Task DeleteProfilePhotoAsync(Guid userId);
    Task DeleteTrainerPhotosAsync(Guid trainerId);
}
