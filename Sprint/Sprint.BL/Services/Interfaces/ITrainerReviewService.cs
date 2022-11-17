using Sprint.BL.Dto.TrainerReview;

namespace Sprint.BL.Services.Interfaces;

public interface ITrainerReviewService
{
    Task<bool> AddReview(Guid trainerReservationId, TrainerReviewDto review);
    Task<List<TrainerReviewDto>> GetUserReviews(Guid userId);
    Task<List<TrainerReviewDto>> GetTrainerReviews(Guid trainerId);
    Task<TrainerReviewDto> GetReview(Guid reservationId);
    Task<int> GetRating(Guid trainerId);
    Task<bool> DeleteReview(Guid reviewId);
}
