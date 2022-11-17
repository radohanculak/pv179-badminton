using Sprint.BL.Dto.CourtReservation;
using Sprint.BL.Dto.Trainer;

namespace Sprint.BL.Dto.TrainerReservation;

public class TrainerReservationDto
{
    public CourtReservationDto CourtReservation { get; set; } = null!;
    
    public TrainerDto Trainer { get; set; } = null!;

    public bool IsDeleted { get; set; }
}
