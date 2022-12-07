using Sprint.Common.Enums;
using Sprint.DAL.EFCore.Models.Base;

namespace Sprint.DAL.EFCore.Models;

public class User : BaseEntity
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string PasswordHash { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string? PhotoPath { get; set; }

    public bool IsTrainer { get; set; }

    public virtual List<CourtReservation> CourtReservations { get; set; }

    public virtual Trainer? Trainer { get; set; }

    public UserRole Role { get; set; }
    
    public string SecurityStamp { get; set; }
}
