using Sprint.BL.Dto.CourtReservation;

namespace Sprint.MVC.Models.User;

public class UserReservationsViewModel
{
    public Guid UserId { get; set; }
    public IEnumerable<CourtReservationDto> Reservations { get; set; }
    public DateTime? From { get; set; }
    public DateTime? To { get; set; }
    public bool AlsoDeleted { get; set; }
    public bool Past { get; set; }

    public UserReservationsViewModel(Guid userId)
    {
        UserId = userId;
        From = null;
        To = null;
        AlsoDeleted = false;
        Past = false;
    }
    
    public UserReservationsViewModel(Guid userId, DateTime from, DateTime to, bool alsoDeleted) : this(userId)
    {
        From = from;
        To = to;
        AlsoDeleted = alsoDeleted;
    }
    
    public UserReservationsViewModel(Guid userId, bool past, bool alsoDeleted) : this(userId)
    {
        Past = past;
        AlsoDeleted = alsoDeleted;
    }
}