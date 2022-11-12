using Sprint.BL.Dto.TrainerPhoto;
using Sprint.BL.Dto.TrainerReservation;

namespace Sprint.BL.Dto.Trainer;

public class TrainerCreateDto
{
    public decimal HourlyRate { get; set; }

    public string? Description { get; set; }
    
    public Guid UserId { get; set; }

    public virtual List<TrainerPhotoDto> Photos { get; set; } = null!;

    public virtual List<TrainerReservationDto> Reservations { get; set; } = null!;
}
