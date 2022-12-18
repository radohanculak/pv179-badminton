using System.ComponentModel.DataAnnotations;

namespace Sprint.MVC.Models.Trainer;

public class TrainerEditViewModel
{
    public Guid Id { get; set; }
    
    [Required]
    [RegularExpression(@"^\d+.?\d{0,2}$", ErrorMessage = "Invalid hourly rate, maximum two decimal points.")]
    public decimal HourlyRate { get; set; }
    [Required]
    public string Description { get; set; }
    
    public TrainerEditViewModel(Guid id, string description, decimal hourlyRate)
    {
        Id = id;
        HourlyRate = hourlyRate;
        Description = description;
    }

    public TrainerEditViewModel()
    {
        
    }
}