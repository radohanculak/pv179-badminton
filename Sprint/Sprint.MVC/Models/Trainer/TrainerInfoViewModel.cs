using Sprint.BL.Dto.Trainer;

namespace Sprint.MVC.Models.Trainer;

public class TrainerInfoViewModel
{
    public TrainerDto Trainer { get; set; }

    public TrainerInfoViewModel(TrainerDto trainer)
    {
        Trainer = trainer;
    }
}