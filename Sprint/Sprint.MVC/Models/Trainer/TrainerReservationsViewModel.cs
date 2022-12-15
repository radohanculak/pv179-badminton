using Sprint.BL.Dto.Court;
using Sprint.BL.Dto.TrainerReservation;
using Sprint.BL.Dto.User;

namespace Sprint.MVC.Models.Trainer;

public class TrainerReservationsViewModel
{
    public Guid TrainerId { get; set; }
    public List<TrainerReservationDto> Reservations { get; set; }
    // povinne potom prerobit
    public List<CourtDto> Courts { get; set; }
    // povinne potom prerobit
    
    public DateTime? From { get; set; }
    public DateTime? To { get; set; }
    public bool AlsoDeleted { get; set; }
    public bool Past { get; set; }
    
    public UserDto User { get; set; }

    public TrainerReservationsViewModel(Guid trainerId)
    {
        TrainerId = trainerId;
        From = null;
        To = null;
        AlsoDeleted = false;
        Past = false;
    }
    
    public TrainerReservationsViewModel(Guid trainerId, DateTime from, DateTime to, bool alsoDeleted) : this(trainerId)
    {
        From = from;
        To = to;
        AlsoDeleted = alsoDeleted;
    }
    
    public TrainerReservationsViewModel(Guid trainerId, bool past, bool alsoDeleted) : this(trainerId)
    {
        Past = past;
        AlsoDeleted = alsoDeleted;
    }
}