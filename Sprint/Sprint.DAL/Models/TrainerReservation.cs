using System.ComponentModel.DataAnnotations.Schema;

namespace Sprint.DAL.Models
{
    public class TrainerReservation : BaseEntity
    {
        public bool IsDeleted { get; set; }

        public int CourtReservationId { get; set; }

        [ForeignKey(nameof(CourtReservationId))]
        public virtual CourtReservation CourtReservation { get; set; }

        public int TrainerId { get; set; }

        [ForeignKey(nameof(TrainerId))]
        public virtual Trainer Trainer { get; set; }

        public int? TrainerReviewId { get; set; }

        [ForeignKey(nameof(TrainerReviewId))]
        public TrainerReview? TrainerReview { get; set; }
    }
}
