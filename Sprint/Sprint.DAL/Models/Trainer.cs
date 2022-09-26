using System.ComponentModel.DataAnnotations.Schema;

namespace Sprint.DAL.Models
{
    public class Trainer : BaseEntity
    {
        public decimal HourlyRate { get; set; }

        public string? Description { get; set; }

        public virtual List<TrainerPhoto> Photos { get; set; }

        public virtual List<TrainerReservation> Reservations { get; set; }

        public virtual List<TrainerReview> Reviews { get; set; }

        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }
    }
}
