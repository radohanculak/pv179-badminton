using System.ComponentModel.DataAnnotations.Schema;

namespace Sprint.DAL.EFCore.Models;

public class TrainerReservation : BaseEntity
{
    public bool IsDeleted { get; set; }

    public Guid CourtReservationId { get; set; }

    [ForeignKey(nameof(CourtReservationId))]
    public virtual CourtReservation CourtReservation { get; set; }

    public Guid TrainerId { get; set; }

    [ForeignKey(nameof(TrainerId))]
    public virtual Trainer Trainer { get; set; }

    public Guid? TrainerReviewId { get; set; }

    [ForeignKey(nameof(TrainerReviewId))]
    public TrainerReview? TrainerReview { get; set; }
}
