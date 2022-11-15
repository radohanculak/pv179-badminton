namespace Sprint.BL.Services.Interfaces;

public interface IPhotoService
{
    Task<bool> AddProfilePhoto(Guid userId, string path);
    Task<bool> AddTrainerPhoto(Guid trainerId, List<string> paths);
    Task<byte[]> GetProfilePhoto(Guid userId);
    Task<List<byte[]>> GetTrainerPhotos(Guid trainerId);
    Task<bool> DeleteProfilePhoto(Guid userId);
    Task<bool> DeleteTrainerPhotos(Guid trainerId);
}
