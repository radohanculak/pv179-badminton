using Sprint.BL.Dto.Trainer;
using Sprint.BL.Dto.TrainerReview;

namespace Sprint.MVC.Models.Trainer;

public class TrainerInfoViewModel
{
    public TrainerDto Trainer { get; set; }
    public List<byte[]> PhotoPaths { get; set; }
    public int? TrainerRating { get; set; }

    public TrainerInfoViewModel(TrainerDto trainer, List<byte[]> photoPaths, int? rating)
    {
        Trainer = trainer;
        PhotoPaths = photoPaths;
        TrainerRating = rating;
    }
}
