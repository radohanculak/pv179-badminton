using Sprint.BL.Dto.CourtReservation;
using Sprint.BL.Dto.Trainer;
using Sprint.BL.Dto.TrainerReservation;
using Sprint.BL.Facades.Interfaces;

namespace Sprint.BL.Facades;

public class AvailableTrainersFacade : IAvailableTrainersFacade
{
    private readonly ITrainerFacade _trainerFacade;
    private readonly ITrainerReservationFacade _trainerReservationFacade;
    private readonly ICourtReservationFacade _courtReservationFacade;

    public AvailableTrainersFacade(
        ITrainerFacade trainerFacade,
        ITrainerReservationFacade trainerReservationFacade,
        ICourtReservationFacade courtReservationFacade
        )
    {
        _trainerFacade = trainerFacade;
        _trainerReservationFacade = trainerReservationFacade;
        _courtReservationFacade = courtReservationFacade;
    }

    public async Task<IEnumerable<TrainerDto>> GetAllAvailableTrainers(DateTime timeFrom)
    {
        var courtTrainerMap = new List<(CourtReservationDto courtReservation, TrainerReservationDto trainerReservation)>();
        var courtReservations = await _courtReservationFacade.GetReservationsForDayAsync(timeFrom);
        var trainerReservations = await _trainerReservationFacade.GetAllReservationsAsync(alsoDeleted: false);
        foreach (var courtReservation in courtReservations)
        {
            var value = trainerReservations.SingleOrDefault(x => x.CourtReservation == courtReservation);
            // we dont care about reservations that do not have trainer assigned
            if (value != null)
            {
                courtTrainerMap.Add((courtReservation, value));
            }
        }

        var trainerReservationDict = new Dictionary<Guid, IEnumerable<(TrainerReservationDto trainerReservation, CourtReservationDto courtReservation)>>();
        var trainers = await _trainerFacade.GetAllTrainersAsync();

        foreach (var trainer in trainers)
        {
            trainerReservationDict.Add(trainer.Id, new List<(TrainerReservationDto trainerReservation, CourtReservationDto courtReservation)>());
        }

        /// each trainer now has all reservations for given day
        foreach (var elem in courtTrainerMap)
        {
            var trainerId = elem.trainerReservation.Trainer.Id;
            if (trainerReservationDict.ContainsKey(trainerId))
            {
                trainerReservationDict[trainerId].Append((elem.trainerReservation, elem.courtReservation));
            }
        }

        var result = new List<TrainerDto>();
        /// iterate over all trainers, available if: they have less than 8 reservations
        /// && they must not have more than 2 reservations in the 11-14h interval

        foreach (var (trainerId, reservations) in trainerReservationDict)
        {
            // trainer is already booked forgiven time
            if (reservations.Any(x => x.courtReservation.From.Hour == timeFrom.Hour))
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
                reservations.Where(x => x.courtReservation.From.Hour >= 11 && x.courtReservation.From.Hour <= 14).Count() >= 2)
            {
                continue;
            }

            var availableTrainer = trainers.SingleOrDefault(x => x.Id == trainerId);
            result.Add(availableTrainer);
        }

        return result;
    }
}