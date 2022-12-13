using Sprint.BL.Facades.Interfaces;
using Sprint.BL.Services.Interfaces;

namespace Sprint.BL.Facades;

public class PhotoFacade : IPhotoFacade
{
    private readonly IPhotoService _photoService;
    private readonly ITrainerService _trainerService;
    private readonly IUserService _userService;

    public PhotoFacade(IPhotoService photoService, ITrainerService trainerService, IUserService userService)
    {
        _photoService = photoService;
        _trainerService = trainerService;
        _userService = userService;
    }

    public async Task AddProfilePhotoAsync(Guid userId, string path)
    {
        var user = await _userService.GetUserAsync(userId);

        await _photoService.AddProfilePhotoAsync(user, path);
    }

    public async Task<bool> AddTrainerPhotoAsync(Guid trainerId, List<string> paths)
    {
        var trainer = await _trainerService.GetTrainerAsync(trainerId);

        return await _photoService.AddTrainerPhotosAsync(trainer, paths);
    }

    public async Task DeleteProfilePhotoAsync(Guid userId)
    {
        var user = await _userService.GetUserAsync(userId);

        await _photoService.DeleteProfilePhotoAsync(user);
    }

    public async Task DeleteTrainerPhotosAsync(Guid trainerId)
    {
        var trainer = await _trainerService.GetTrainerAsync(trainerId);

        await _photoService.DeleteTrainerPhotosAsync(trainer);
    }

    public async Task<string> GetProfilePhotoAsync(Guid userId)
    {
        var user = await _userService.GetUserAsync(userId);

        return _photoService.GetProfilePhoto(user);
    }

    public async Task<List<string>> GetTrainerPhotosAsync(Guid trainerId)
    {
        var trainer = await _trainerService.GetTrainerAsync(trainerId);

        return _photoService.GetTrainerPhotos(trainer);
    }
}
