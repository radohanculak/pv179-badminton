using Sprint.BL.Dto.TrainerReservation;
using Sprint.BL.Dto.TrainerReview;

namespace Sprint.BL.Services.Interfaces;

public interface ITrainerReviewService
{
    Task<TrainerReviewDto> AddReviewAsync(TrainerReservationDto trainerReservation, int rating, string text);
    Task<List<TrainerReviewDto>> GetTrainerReviewsAsync(Guid trainerId);
    Task<List<TrainerReviewDto>> GetAllReviewsAsync();
    Task<TrainerReviewDto?> GetReviewAsync(Guid reviewId);
    Task<TrainerReviewDto?> GetReviewForReservationAsync(Guid reservationId);
    Task<int?> GetRatingAsync(Guid trainerId);
    Task DeleteReviewAsync(Guid reviewId);
}
