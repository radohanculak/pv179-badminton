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
    private readonly ITrainerService _trainerService;

    public TrainerReviewService(IUnitOfWork unitOfWork, IMapper mapper, ITrainerService trainerService,
        IUserService userService, ITrainerReservationService trainerReservationService)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _userService = userService;
        _trainerReservationService = trainerReservationService;
        _trainerService = trainerService;
    }

    public async Task<TrainerReviewDto> AddReviewAsync(Guid trainerReservationId, int rating, string text)
    {
        Guard.Against.NullOrWhiteSpace(text);   
        Guard.Against.OutOfRange(rating, nameof(rating), 0, 10);

        var reservation = await _trainerReservationService.GetReservationAsync(trainerReservationId);

        var newReview = new TrainerReviewDto
        {
            Rating = rating,
            Text = text,
            ReservationId = reservation.Id
        };

        var reviewId = await _unitOfWork.TrainerReviewRepository.InsertAsync(_mapper.Map<TrainerReview>(newReview));
        
        await _unitOfWork.CommitAsync();

        return await GetReviewAsync(reviewId);
    }

    public async Task<List<TrainerReviewDto>> GetAllReviewsAsync()
    {
        return _mapper.Map<List<TrainerReviewDto>>(await _unitOfWork.TrainerReviewRepository.GetAllAsync());
    }

    public async Task<List<TrainerReviewDto>> GetTrainerReviewsAsync(Guid trainerId)
    {
        _ = await _trainerService.GetTrainerAsync(trainerId);

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
        var reservation = await _trainerReservationService.GetReservationAsync(reservationId);
        var reviews = await _unitOfWork.TrainerReviewRepository.GetAllAsync();

        var review = reviews.FirstOrDefault(r => r.ReservationId == reservationId);

        return _mapper.Map<TrainerReviewDto>(review);
    }

    public async Task<int?> GetRatingAsync(Guid trainerId)
    {
        var reviews = await GetTrainerReviewsAsync(trainerId);

        if (reviews.Count == 0)
        {
            return null;
        }

        var sum =  reviews.Select(r => r.Rating).Aggregate(0, (r1, r2) => r1 + r2);
        return sum / reviews.Count();
    }

    public async Task DeleteReviewAsync(Guid reviewId)
    {
        var review = GetReviewAsync(reviewId);

        await _unitOfWork.TrainerReviewRepository.DeleteByIdAsync(reviewId);
    }
}
