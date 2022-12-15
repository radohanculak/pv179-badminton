using Sprint.BL.Dto.TrainerReservation;
using Sprint.BL.Facades.Interfaces;
using Sprint.BL.Services.Interfaces;

namespace Sprint.BL.Facades;

public class TrainerReservationFacade : ITrainerReservationFacade
{
    private readonly ITrainerReservationService _trainerReservationService;
    private readonly ICourtReservationService _courtReservationService;
    private readonly ITrainerService _trainerService;
    private readonly ICourtService _courtService;
    private readonly IUserService _userService;

    public TrainerReservationFacade(ITrainerReservationService trainerReservationService,
        ICourtReservationService courtReservationService, ITrainerService trainerService,
        ICourtService courtService, IUserService userService)
    {
        _trainerReservationService = trainerReservationService;
        _courtReservationService = courtReservationService;
        _trainerService = trainerService;
        _courtService = courtService;
        _userService = userService;
    }

    public async Task<TrainerReservationDto> AddReservationAsync(Guid courtResId, Guid trainerId)
    {
        var courtReservation = await _courtReservationService.GetReservationAsync(courtResId);

        return await _trainerReservationService.AddReservationAsync(courtReservation, trainerId);
    }
    
    public async Task<TrainerReservationDto> AddReservationWithCourtAsync(Guid userId, Guid trainerId, Guid courtId, DateTime from, DateTime to)
    {
        _ = await _trainerService.GetTrainerAsync(trainerId);
        var courtReservation = await _courtReservationService.AddReservationAsync(userId, courtId, from, to);

        return await _trainerReservationService.AddReservationAsync(courtReservation, trainerId);
    }

    public async Task DeleteReservationAsync(Guid reservationId, bool keepCourtReservation)
    {
        var reservation = await _trainerReservationService.GetReservationAsync(reservationId);

        if (!keepCourtReservation)
        {
            await _courtReservationService.DeleteReservationAsync(reservation.CourtReservation.Id);
        }

        await _trainerReservationService.DeleteReservationAsync(reservation);
    }

    public async Task<List<TrainerReservationDto>> GetAllReservationsAsync(bool alsoDeleted)
    {
        return await _trainerReservationService.GetAllReservationsAsync(alsoDeleted);
    }

    public async Task<TrainerReservationDto> GetReservationAsync(Guid reservationId)
    {
        return await _trainerReservationService.GetReservationAsync(reservationId);
    }

    public async Task<List<TrainerReservationDto>> GetReservationsForTrainerAsync(Guid trainerId, bool inPast, bool alsoDeleted)
    {
        var trainer = await _trainerService.GetTrainerAsync(trainerId);

        return _trainerReservationService.GetReservationsForTrainer(trainer, inPast, alsoDeleted);
    }

    public async Task<List<TrainerReservationDto>> GetReservationsForUserAsync(Guid userId, bool inPast, bool alsoDeleted)
    {
        return await _trainerReservationService.GetReservationsForUserAsync(userId, inPast, alsoDeleted);
    }

    public async Task<string> GetTrainerDailyScheduleAsync(Guid trainerId, DateTime date)
    {
        var trainer = await _trainerService.GetTrainerAsync(trainerId);

        var schedule = _trainerReservationService.GetTrainerDailySchedule(trainer, date);
        
        List<XmlScheduleModel> scheduleModel = new List<XmlScheduleModel>();

        foreach (var reservation in schedule)
        {
            var user = await _userService.GetUserAsync(reservation.CourtReservation.UserId);
            scheduleModel.Add(new XmlScheduleModel
            {
                From = reservation.CourtReservation.From,
                To = reservation.CourtReservation.To,
                CourtName = (await _courtService.GetCourtAsync(reservation.CourtReservation.CourtId)).CourtNumber,
                TraineeName = user.FirstName + " " + user.LastName
            });
        }
        
        var xmlSerializer = new System.Xml.Serialization.XmlSerializer(scheduleModel.GetType());

        using (var textWriter = new StringWriter())
        {
            xmlSerializer.Serialize(textWriter, scheduleModel);
            return textWriter.ToString();
        }
        
    }
}
