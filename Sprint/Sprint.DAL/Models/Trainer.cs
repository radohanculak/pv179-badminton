namespace Sprint.DAL.Models;

public class Trainer : BaseEntity
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string PasswordHash { get; set; }

    public decimal HourlyRate { get; set; }

    public string? Description { get; set; }

    public virtual List<TrainerPhoto> Photos { get; set; }

    public virtual List<TrainerReservation> Reservations { get; set; }
}
