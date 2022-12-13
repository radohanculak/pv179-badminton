using Sprint.BL.Dto.CourtReservation;
using Sprint.BL.Dto.Trainer;
using Sprint.Common.Enums;

namespace Sprint.BL.Dto.User;

public class UserDto
{
    public Guid Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public int Age { get; set; }

    public DateTime DateOfBirth { get; set; }
    public string PasswordHash { get; set; }
    
    public string Password { get; set; }

    public string? PhotoPath { get; set; }

    // Deprecated, use Role instead
    // public bool IsTrainer { get; set; }

    public TrainerDto? Trainer { get; set; }

    public List<CourtReservationDto> CourtReservations { get; set; } = null!;

    public UserRole Role { get; set; }
    
    public string SecurityStamp { get; set; }
    
    public bool IsDeleted { get; set; } = false;
}
