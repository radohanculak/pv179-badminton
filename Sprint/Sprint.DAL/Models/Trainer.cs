using Sprint.DAL.EFCore.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sprint.DAL.EFCore.Models;

public class Trainer : BaseEntity
{
    public decimal HourlyRate { get; set; }

    public string? Description { get; set; }

    public Guid UserId { get; set; }

    [ForeignKey(nameof(UserId))]
    public virtual User User { get; set; }

    public virtual List<TrainerPhoto> Photos { get; set; }

    public virtual List<TrainerReservation> Reservations { get; set; }
}
