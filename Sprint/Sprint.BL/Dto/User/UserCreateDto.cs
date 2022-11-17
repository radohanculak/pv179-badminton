using Sprint.BL.Dto.CourtReservation;
using Sprint.BL.Dto.Trainer;
using Sprint.DAL.EFCore.Models;

namespace Sprint.BL.Dto.User;

public class UserCreateDto
{
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;
    
    public DateTime DateOfBirth { get; set; }
    
    public string PhotoPath { get; set; } = null!;
    
    public bool IsTrainer { get; set; } = false;

    public virtual TrainerDto Trainer { get; set; } = null!;

    public UserRole Role { get; set; }
}
