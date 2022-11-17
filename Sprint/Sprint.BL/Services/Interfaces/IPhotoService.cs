namespace Sprint.BL.Services.Interfaces;

public interface IPhotoService
{
    Task<bool> AddProfilePhotoAsync(Guid userId, string path);
    Task<bool> AddTrainerPhotoAsync(Guid trainerId, List<string> paths);
    Task<byte[]> GetProfilePhotoAsync(Guid userId);
    Task<List<byte[]>> GetTrainerPhotosAsync(Guid trainerId);
    Task<bool> DeleteProfilePhotoAsync(Guid userId);
    Task<bool> DeleteTrainerPhotosAsync(Guid trainerId);
}
