using Sprint.BL.Dto.Trainer;
using System.ComponentModel.DataAnnotations;

namespace Sprint.MVC.Models.TrainerReservation;

public class TrainerReservationCreateModel
{
    public Guid TrainerId { get; set; }

    public Guid CourtResId { get; set; }

    public DateTime TimeFrom { get; set; }

    public DateTime TimeTo { get; set; }
    
    // available trainers
    public IEnumerable<TrainerDto> TrainerDtos { get; set; }

    // filters
    [Display(Name = "Minimum rating:")]
    public int MinRating { get; set; }

    [Display(Name = "Minimum price:")]
    public int MinPrice { get; set; }

    [Display(Name = "Maximum price:")]
    public int MaxPrice { get; set; } = 5000;
}
