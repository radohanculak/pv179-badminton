using Sprint.BL.Dto.TrainerReview;

namespace Sprint.MVC.Models.TrainerReview;

public class OneTrainerReviewsViewModel
{
    public List<TrainerReviewDto> Reviews { get; set; }

    public OneTrainerReviewsViewModel(List<TrainerReviewDto> reviews)
    {
        Reviews = reviews;
    }
}