using Sprint.BL.Dto.Court;
using Sprint.BL.Dto.TrainerReservation;
using Sprint.BL.Dto.User;

namespace Sprint.BL.Dto.CourtReservation;

public class CourtReservationDto
{
    public Guid Id { get; set; }

    public DateTime Created { get; set; }

    public DateTime From { get; set; }

    public DateTime To { get; set; }

    public UserDto User { get; set; } = null!;
    
    public CourtDto Court { get; set; } = null!;
    
    public TrainerReservationDto? TrainerReservation { get; set; }
}
