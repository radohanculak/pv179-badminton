using Sprint.BL.Dto.TrainerReservation;

namespace Sprint.BL.Dto.CourtReservation;

public class CourtReservationDto
{
    public Guid Id { get; set; }

    public DateTime Created { get; set; }

    public DateTime From { get; set; }

    public DateTime To { get; set; }

    public Guid UserId { get; set; }
    
    public Guid CourtId { get; set; }
    
    public TrainerReservationDto? TrainerReservation { get; set; }

    public bool IsDeleted { get; set; } = false;
}
