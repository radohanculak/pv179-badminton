using System.ComponentModel.DataAnnotations.Schema;

namespace Sprint.DAL.Models
{
    public class TrainerReview : BaseEntity
    {
        public int Rating { get; set; }

        public string Text { get; set; }

        public bool Hide { get; set; }

        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }

        public int TrainerId { get; set; }

        [ForeignKey(nameof(TrainerId))]
        public virtual Trainer Trainer { get; set; }
    }
}