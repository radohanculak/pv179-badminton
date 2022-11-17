using Sprint.DAL.EFCore.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sprint.DAL.EFCore.Models;

public class TrainerReview : BaseEntity
{
    public int Rating { get; set; }

    public string Text { get; set; }

    public bool Hide { get; set; }

    public Guid ReservationId { get; set; }

    [ForeignKey(nameof(ReservationId))]

    public TrainerReservation Reservation { get; set; } = null!;
}
