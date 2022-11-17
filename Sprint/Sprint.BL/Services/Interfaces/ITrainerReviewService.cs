using Sprint.BL.Dto.TrainerReview;

namespace Sprint.BL.Services.Interfaces;

public interface ITrainerReviewService
{
    Task AddReviewAsync(Guid trainerReservationId, int rating, string text);
    Task<List<TrainerReviewDto>> GetUserReviewsAsync(Guid userId);
    Task<List<TrainerReviewDto>> GetTrainerReviewsAsync(Guid trainerId);
    Task<TrainerReviewDto?> GetReviewAsync(Guid reviewId);
    Task<TrainerReviewDto?> GetReviewForReservationAsync(Guid reservationId);
    Task<int> GetRatingAsync(Guid trainerId);
    Task DeleteReviewAsync(Guid reviewId);
}
