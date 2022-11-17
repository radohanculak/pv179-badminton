using Ardalis.GuardClauses;
using AutoMapper;
using Sprint.BL.Dto.TrainerReview;
using Sprint.BL.Services.Interfaces;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.UnitOfWork;

namespace Sprint.BL.Services;

public class TrainerReviewService : ITrainerReviewService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserService _userService;
    private readonly ITrainerReservationService _trainerReservationService;

    public TrainerReviewService(IUnitOfWork unitOfWork, IMapper mapper,
        IUserService userService, ITrainerReservationService trainerReservationService)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _userService = userService;
        _trainerReservationService = trainerReservationService;
    }

    public async Task AddReviewAsync(Guid trainerReservationId, int rating, string text)
    {
        Guard.Against.NullOrEmpty(text);
        Guard.Against.OutOfRange(rating, nameof(rating), 0, 10);

        var review = new TrainerReviewDto
        {
            Rating = rating,
            Text = text
        };

        var reservation = await _trainerReservationService.GetReservationAsync(trainerReservationId);
        reservation.TrainerReview = review;

        _unitOfWork.TrainerReservationRepository.Update(_mapper.Map<TrainerReservation>(reservation));
        await _unitOfWork.CommitAsync();
    }

    public async Task<List<TrainerReviewDto>> GetAllReviews()
    {
        return _mapper.Map<List<TrainerReviewDto>>(await _unitOfWork.TrainerReviewRepository.GetAllAsync());
    }

    public async Task<List<TrainerReviewDto>> GetUserReviewsAsync(Guid userId)
    {
        _ = await _userService.GetUserAsync(userId);

        var reservations = await _trainerReservationService.GetReservationsForUserAsync(userId, true);

        return reservations.Where(r => r.TrainerReview != null).Select(r => r.TrainerReview).ToList();
    }

    public async Task<List<TrainerReviewDto>> GetTrainerReviewsAsync(Guid trainerId)
    {
        _ = await _userService.GetUserAsync(trainerId);

        var reservations = await _trainerReservationService.GetReservationsForTrainerAsync(trainerId, true);

        return reservations.Where(r => r.TrainerReview != null).Select(r => r.TrainerReview).ToList();
    }

    public async Task<TrainerReviewDto> GetReviewAsync(Guid reviewId)
    {
        var review = _unitOfWork.TrainerReviewRepository.GetByIdAsync(reviewId);

        if (review == null)
        {
            throw new InvalidOperationException($"Trainer review with id {reviewId} does not exist");
        }

        return _mapper.Map<TrainerReviewDto>(review);
    }

    public async Task<TrainerReviewDto?> GetReviewForReservationAsync(Guid reservationId)
    {
        var reservation = await _trainerReservationService.GetReservationAsync(reservationId);

        return reservation.TrainerReview;
    }

    public async Task<int> GetRatingAsync(Guid trainerId)
    {
        var reviews = await GetTrainerReviewsAsync(trainerId);

        var sum =  reviews.Select(r => r.Rating).Aggregate((r1, r2) => r1 + r2);
        return sum / reviews.Count();
    }

    public async Task DeleteReviewAsync(Guid reviewId)
    {
        var review = GetReviewAsync(reviewId);

        await _unitOfWork.TrainerReviewRepository.DeleteByIdAsync(reviewId);
    }
}
