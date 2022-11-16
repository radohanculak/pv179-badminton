using AutoMapper;
using Sprint.BL.Dto.TrainerPhoto;
using Sprint.BL.Services.Interfaces;
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

    public async Task<bool> AddProfilePhoto(Guid userId, string path)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> AddTrainerPhoto(Guid trainerId, List<string> paths)
    {
        throw new NotImplementedException();
    }

    public async Task<byte[]> GetProfilePhoto(Guid userId)
    {
        throw new NotImplementedException();
    }

    public async Task<List<byte[]>> GetTrainerPhotos(Guid trainerId)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteProfilePhoto(Guid userId)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteTrainerPhotos(Guid trainerId)
    {
        throw new NotImplementedException();
    }
}
