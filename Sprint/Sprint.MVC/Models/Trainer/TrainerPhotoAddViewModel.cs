using System.ComponentModel.DataAnnotations;

namespace Sprint.MVC.Models.Trainer;

public class TrainerPhotoAddViewModel
{
    public Guid TrainerId { get; set; }
    
    [Required]
    public string PhotoPath { get; set; }

    public TrainerPhotoAddViewModel(Guid trainerId)
    {
        TrainerId = trainerId;
    }

    public TrainerPhotoAddViewModel()
    {
        
    }
}