using Sprint.BL.Dto.Trainer;
using Sprint.BL.Dto.TrainerReservation;
using Sprint.BL.Facades.Interfaces;
using Sprint.BL.Services.Interfaces;

namespace Sprint.BL.Facades;

public class AvailableTrainersFacade : IAvailableTrainersFacade
{
    private readonly ITrainerService _trainerService;
    private readonly ITrainerReviewService _trainerReviewService;
    private readonly ITrainerReservationService _trainerReservationService;

    public AvailableTrainersFacade(ITrainerService trainerService, ITrainerReviewService trainerReviewService,
        ITrainerReservationService trainerReservationService)
    {
        _trainerService = trainerService;
        _trainerReviewService = trainerReviewService;
        _trainerReservationService = trainerReservationService;
    }

    public async Task<IEnumerable<TrainerDto>> GetAllAvailableTrainers(DateTime timeFrom, int minRating, int minPrice, int maxPrice)
    {
        var trainers = await _trainerService.GetFilteredTrainersAsync(minPrice, maxPrice);
        var trainerReservations = new List<(TrainerDto trainer, List<TrainerReservationDto> trainerReservations)>();

        foreach (var trainer in trainers)
        {
            var rating = await _trainerReviewService.GetRatingAsync(trainer.Id) ?? 0;
            if (rating >= minRating)
            {
                var reservations = _trainerReservationService.GetDailyReservationsForTrainer(trainer, timeFrom.Date);
                trainerReservations.Add((trainer, reservations));
            }
        }

        var result = new List<TrainerDto>();

        foreach (var (trainer, reservations) in trainerReservations)
        {
            // trainer is already booked for given time
            if (reservations.Any(x => x.CourtReservation.From.Hour == timeFrom.Hour))
            {
                continue;
            }

            // trainer has already 8 reservations
            if (reservations.Count() > 8)
            {
                continue;
            }

            // lunch time
            if (timeFrom.Hour is >= 11 and <= 14 &&
                reservations.Count(x => x.CourtReservation.From.Hour is >= 11 and <= 14) >= 2)
            {
                continue;
            }

            result.Add(trainer);
        }

        return result;
    }
}