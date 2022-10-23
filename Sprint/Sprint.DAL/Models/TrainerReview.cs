using Sprint.DAL.EFCore.Models.Base;

namespace Sprint.DAL.EFCore.Models;

public class TrainerReview : BaseEntity
{
    public int Rating { get; set; }

    public string Text { get; set; }

    public bool Hide { get; set; }
}
