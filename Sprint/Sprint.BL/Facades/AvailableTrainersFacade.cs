using Sprint.BL.Dto.Trainer;
using Sprint.BL.Dto.TrainerReservation;
using Sprint.BL.Facades.Interfaces;
using Sprint.BL.Services.Interfaces;

namespace Sprint.BL.Facades;

public class AvailableTrainersFacade : IAvailableTrainersFacade
{
    private readonly ITrainerService _trainerService;
    private readonly ITrainerReservationService _trainerReservationService;

    public AvailableTrainersFacade(ITrainerService trainerService,
        ITrainerReservationService trainerReservationService)
    {
        _trainerService = trainerService;
        _trainerReservationService = trainerReservationService;
    }

    public async Task<IEnumerable<TrainerDto>> GetAllAvailableTrainers(DateTime timeFrom)
    {
        var trainers = await _trainerService.GetAllTrainersAsync();
        var trainerReservations = new List<(TrainerDto trainer, List<TrainerReservationDto> trainerReservations)>();

        foreach (var trainer in trainers)
        {
            var reservations = _trainerReservationService.GetDailyReservationsForTrainer(trainer, timeFrom.Date);

            trainerReservations.Add((trainer, reservations));
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
            if (timeFrom.Hour >= 11 &&
                timeFrom.Hour <= 14 &&
                reservations.Where(x => x.CourtReservation.From.Hour >= 11 && x.CourtReservation.From.Hour <= 14).Count() >= 2)
            {
                continue;
            }

            result.Add(trainer);
        }

        return result;
    }
}