using Sprint.BL.Dto.Trainer;

namespace Sprint.MVC.Models.Trainer;

public class TrainerInfoViewModel
{
    public TrainerDto Trainer { get; set; }
    public List<string> PhotoPaths { get; set; }
    public int? TrainerRating { get; set; }

    public TrainerInfoViewModel(TrainerDto trainer, List<string> photoPaths, int? rating)
    {
        Trainer = trainer;
        PhotoPaths = photoPaths;
        TrainerRating = rating;
    }
}
