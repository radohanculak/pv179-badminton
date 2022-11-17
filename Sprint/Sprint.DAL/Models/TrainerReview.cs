using Sprint.DAL.EFCore.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sprint.DAL.EFCore.Models;

public class TrainerReview : BaseEntity
{
    public int Rating { get; set; }

    public string Text { get; set; }

    public bool Hide { get; set; }

    public Guid TrainerId { get; set; }

    [ForeignKey(nameof(TrainerId))]
    public Trainer Trainer { get; set; }
}
