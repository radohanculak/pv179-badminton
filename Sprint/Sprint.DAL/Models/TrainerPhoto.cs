using System.ComponentModel.DataAnnotations.Schema;

namespace Sprint.DAL.EFCore.Models;

public class TrainerPhoto : BaseEntity
{
    public string Path { get; set; }

    public bool Hide { get; set; }

    public Guid TrainerId { get; set; }

    [ForeignKey(nameof(TrainerId))]
    public Trainer Trainer { get; set; }
}
