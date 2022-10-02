using System.ComponentModel.DataAnnotations.Schema;

namespace Sprint.DAL.Models;

public class CourtReservation : BaseEntity
{
    public DateTime Created { get; set; }

    public DateTime From { get; set; }

    public DateTime To { get; set; }

    public bool IsDeleted { get; set; }

    public int UserId { get; set; }

    [ForeignKey(nameof(UserId))] public virtual User User { get; set; }

    public int CourtId { get; set; }

    [ForeignKey(nameof(CourtId))] public virtual Court Court { get; set; }

    public virtual TrainerReservation TrainerReservation { get; set; }
}
