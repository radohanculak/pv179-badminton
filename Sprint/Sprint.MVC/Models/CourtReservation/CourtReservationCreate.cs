using System.ComponentModel.DataAnnotations;
using Sprint.BL.Dto.Court;
using Sprint.BL.Dto.CourtReservation;

namespace Sprint.MVC.Models.CourtReservation;

public class CourtReservationCreate
{
    [Required]
    [DataType(DataType.Date)]
    [Display(Name = "Court Reservation Date")]
    public DateTime Date { get; set; }
    
    /// all court reservations for given day
    public List<CourtReservationDto> CourtReservationDtos { get; set; }
    public List<CourtDto> CourtDtos { get; set; }
    public DateTime TimeFrom { get; set; }
    public DateTime TimeTo { get; set; }
    public Guid CourtId { get; set; }
}
