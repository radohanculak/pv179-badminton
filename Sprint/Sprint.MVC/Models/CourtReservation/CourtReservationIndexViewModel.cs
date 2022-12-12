using Sprint.BL.Dto.CourtReservation;

namespace Sprint.MVC.Models.CourtReservation;

public class CourtReservationIndexViewModel
{
    public IEnumerable<CourtReservationDto> CourtReservations { get; set; }
}
