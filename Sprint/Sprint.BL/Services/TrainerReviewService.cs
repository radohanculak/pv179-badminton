using Ardalis.GuardClauses;
using AutoMapper;
using Sprint.BL.Dto.TrainerReservation;
using Sprint.BL.Dto.TrainerReview;
using Sprint.BL.Services.Interfaces;
using Sprint.DAL.EFCore.Models;
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

    public async Task<TrainerReviewDto> AddReviewAsync(TrainerReservationDto reservation, int rating, string text)
    {
        Guard.Against.NullOrWhiteSpace(text);   
        Guard.Against.OutOfRange(rating, nameof(rating), 0, 10);

        var newReview = new TrainerReviewDto
        {
            Rating = rating,
            Text = text,
            ReservationId = reservation.Id
        };

        var reviewId = await _unitOfWork.TrainerReviewRepository.InsertAsync(_mapper.Map<TrainerReview>(newReview));
        
        await _unitOfWork.CommitAsync();
        _unitOfWork.TrainerReviewRepository.ClearTracking();

        return await GetReviewAsync(reviewId);
    }

    public async Task<List<TrainerReviewDto>> GetAllReviewsAsync()
    {
        return _mapper.Map<List<TrainerReviewDto>>(await _unitOfWork.TrainerReviewRepository.GetAllAsync());
    }

    public async Task<List<TrainerReviewDto>> GetTrainerReviewsAsync(Guid trainerId)
    {
        var reviews = await _unitOfWork.TrainerReviewRepository.GetAllAsync();

        reviews = reviews.Where(review => review.Reservation.TrainerId == trainerId).ToList();

        return _mapper.Map<List<TrainerReviewDto>>(reviews);
    }

    public async Task<TrainerReviewDto> GetReviewAsync(Guid reviewId)
    {
        var review = await _unitOfWork.TrainerReviewRepository.GetByIdAsync(reviewId);

        if (review == null)
        {
            throw new InvalidOperationException($"Trainer review with id {reviewId} does not exist");
        }

        return _mapper.Map<TrainerReviewDto>(review);
    }

    public async Task<TrainerReviewDto?> GetReviewForReservationAsync(Guid reservationId)
    {
        var reviews = await _unitOfWork.TrainerReviewRepository.GetAllAsync();

        var review = reviews.FirstOrDefault(r => r.ReservationId == reservationId);

        return _mapper.Map<TrainerReviewDto>(review);
    }

    public async Task<int?> GetRatingAsync(Guid trainerId)
    {
        var reviews = await GetTrainerReviewsAsync(trainerId);

        if (!reviews.Any())
        {
            return null;
        }

        var sum =  reviews.Select(r => r.Rating).Aggregate(0, (r1, r2) => r1 + r2);
        return sum / reviews.Count();
    }

    public async Task DeleteReviewAsync(Guid reviewId)
    {
        _ = GetReviewAsync(reviewId);

        await _unitOfWork.TrainerReviewRepository.DeleteByIdAsync(reviewId);
    }
}
