using Sprint.BL.Dto.Trainer;

namespace Sprint.MVC.Models.Trainer;

public class TrainerIndexViewModel
{
    public IEnumerable<TrainerDto> Trainers { get; set; }
}