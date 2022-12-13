using Sprint.BL.Dto.TrainerPhoto;
using Sprint.BL.Dto.TrainerReservation;
using Sprint.BL.Dto.User;

namespace Sprint.BL.Dto.Trainer;

public class TrainerDto
{
    public Guid Id { get; set; }
    
    public decimal HourlyRate { get; set; }

    public string? Description { get; set; }
    
    public UserDto User { get; set; } = null!;
    
    public List<TrainerPhotoDto> Photos { get; set; } = null!;

    public List<TrainerReservationDto> Reservations { get; set; } = null!;
    
    public bool IsDeleted { get; set; } = false;
}
