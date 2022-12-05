using Sprint.BL.Dto.CourtReservation;
using Sprint.BL.Dto.Trainer;
using Sprint.Common.Enums;

namespace Sprint.BL.Dto.User;

public class UserDto
{
    public Guid Id { get; set; }
    
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;
    
    public string Email { get; set; } = null!;

    public int Age { get; set; }
    
    public string? PhotoPath { get; set; } = null!;

    public bool IsTrainer { get; set; }

    public virtual TrainerDto Trainer { get; set; } = null!;

    public virtual List<CourtReservationDto> CourtReservations { get; set; } = null!;

    public UserRole Role { get; set; }
}
