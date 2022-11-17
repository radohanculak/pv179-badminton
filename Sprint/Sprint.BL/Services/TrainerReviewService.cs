using AutoMapper;
using Sprint.BL.Dto.TrainerReview;
using Sprint.BL.Services.Interfaces;
using Sprint.Infrastructure.UnitOfWork;

namespace Sprint.BL.Services;

public class TrainerReviewService : ITrainerReviewService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public TrainerReviewService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<bool> AddReview(Guid trainerReservationId, TrainerReviewDto review)
    {
        throw new NotImplementedException();
    }

    public async Task<List<TrainerReviewDto>> GetAllReviews()
    {
        return _mapper.Map<List<TrainerReviewDto>>(await _unitOfWork.TrainerReviewRepository.GetAllAsync());
    }

    public async Task<List<TrainerReviewDto>> GetUserReviews(Guid userId)
    {
        var user = await _unitOfWork.UserRepository.GetByIdAsync(userId);

        if (user == null)
        {
            new InvalidOperationException($"User with id {userId} does not exist");
        }

        //return _mapper.Map<List<TrainerReviewDto>>(user.CourtReservations?.Select(r => r.))
        // get user a pak se zeptat na reviews
        throw new NotImplementedException();
    }

    public async Task<List<TrainerReviewDto>> GetTrainerReviews(Guid trainerId)
    {
        throw new NotImplementedException();
    }

    public async Task<TrainerReviewDto> GetReview(Guid reservationId)
    {
        throw new NotImplementedException();
    }

    public async Task<int> GetRating(Guid trainerId)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteReview(Guid reviewId)
    {
        throw new NotImplementedException();
    }
}
