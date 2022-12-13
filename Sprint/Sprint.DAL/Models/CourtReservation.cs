using System.ComponentModel.DataAnnotations.Schema;
using Sprint.DAL.EFCore.Models.Base;

namespace Sprint.DAL.EFCore.Models;

public class CourtReservation : BaseEntity
{
    public DateTime Created { get; set; }

    public DateTime From { get; set; }

    public DateTime To { get; set; }

    public Guid UserId { get; set; }

    [ForeignKey(nameof(UserId))]
    public virtual User User { get; set; }

    public Guid CourtId { get; set; }

    [ForeignKey(nameof(CourtId))]
    public virtual Court Court { get; set; }

    public virtual TrainerReservation? TrainerReservation { get; set; }
}
