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

    public async Task<List<TrainerReviewDto>> GetReviews(Guid trainerId)
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
