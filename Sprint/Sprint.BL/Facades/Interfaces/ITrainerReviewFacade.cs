using Sprint.BL.Dto.TrainerReview;

namespace Sprint.BL.Facades.Interfaces;

public interface ITrainerReviewFacade
{
    Task<TrainerReviewDto> AddReviewAsync(Guid trainerReservationId, int rating, string text);
    Task<List<TrainerReviewDto>> GetTrainerReviewsAsync(Guid trainerId);
    Task<List<TrainerReviewDto>> GetAllReviewsAsync();
    Task<TrainerReviewDto?> GetReviewAsync(Guid reviewId);
    Task<TrainerReviewDto?> GetReviewForReservationAsync(Guid reservationId);
    Task<int?> GetRatingAsync(Guid trainerId);
    Task DeleteReviewAsync(Guid reviewId);
}
