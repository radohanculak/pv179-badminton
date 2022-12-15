using Sprint.BL.Dto.Court;
using Sprint.BL.Dto.CourtReservation;

namespace Sprint.MVC.Models.CourtReservation;

public class CourtReservationIndexViewModel
{
    public IEnumerable<CourtReservationDto> CourtReservations { get; set; }
    
    // povinne potom prerobit
    public List<CourtDto> Courts { get; set; }
    // povinne potom prerobit
}
