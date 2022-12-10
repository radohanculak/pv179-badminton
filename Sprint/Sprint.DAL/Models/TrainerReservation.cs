using System.ComponentModel.DataAnnotations.Schema;
using Sprint.DAL.EFCore.Models.Base;

namespace Sprint.DAL.EFCore.Models;

public class TrainerReservation : DeletableEntity
{
    public Guid CourtReservationId { get; set; }

    [ForeignKey(nameof(CourtReservationId))]
    public virtual CourtReservation CourtReservation { get; set; }

    public Guid TrainerId { get; set; }

    [ForeignKey(nameof(TrainerId))]
    public virtual Trainer Trainer { get; set; }

    //public Guid? TrainerReviewId { get; set; }

    // skusit odstranit tento foreign key
    //[ForeignKey(nameof(TrainerReviewId))]
    public virtual TrainerReview? TrainerReview { get; set; }
}
