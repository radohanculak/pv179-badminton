using Sprint.BL.Dto.TrainerReview;
using Sprint.BL.Facades.Interfaces;
using Sprint.BL.Services.Interfaces;

namespace Sprint.BL.Facades;

public class TrainerReviewFacade : ITrainerReviewFacade
{
    private readonly ITrainerReviewService _trainerReviewService;
    private readonly ITrainerService _trainerService;
    private readonly ITrainerReservationService _trainerReservationService;

    public TrainerReviewFacade(ITrainerReviewService trainerReviewService, ITrainerService trainerService,
        ITrainerReservationService trainerReservationService)
    {
        _trainerReviewService = trainerReviewService;
        _trainerService = trainerService;
        _trainerReservationService = trainerReservationService;
    }

    public async Task<TrainerReviewDto> AddReviewAsync(Guid trainerReservationId, int rating, string text)
    {
        var reservation = await _trainerReservationService.GetReservationAsync(trainerReservationId);

        return await _trainerReviewService.AddReviewAsync(reservation, rating, text);
    }

    public async Task DeleteReviewAsync(Guid reviewId)
    {
        await _trainerReviewService.DeleteReviewAsync(reviewId);
    }

    public async Task<List<TrainerReviewDto>> GetAllReviewsAsync()
    {
        return await _trainerReviewService.GetAllReviewsAsync();
    }

    public async Task<int?> GetRatingAsync(Guid trainerId)
    {
        _ = await _trainerService.GetTrainerAsync(trainerId);

        return await _trainerReviewService.GetRatingAsync(trainerId);
    }

    public async Task<TrainerReviewDto?> GetReviewAsync(Guid reviewId)
    {
        return await _trainerReviewService.GetReviewAsync(reviewId);
    }

    public async Task<TrainerReviewDto?> GetReviewForReservationAsync(Guid reservationId)
    {
        _ = await _trainerReservationService.GetReservationAsync(reservationId);

        return await _trainerReviewService.GetReviewForReservationAsync(reservationId);
    }

    public async Task<List<TrainerReviewDto>> GetTrainerReviewsAsync(Guid trainerId)
    {
        _ = await _trainerService.GetTrainerAsync(trainerId);

        return await _trainerReviewService.GetTrainerReviewsAsync(trainerId);
    }
}
