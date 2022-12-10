using System.ComponentModel.DataAnnotations;

namespace Sprint.MVC.Models.Court;

public class CourtEditViewModel
{
    public Guid Id { get; set; }

    [Required]
    public string CourtNumber { get; set; }

    [Required]
    [RegularExpression(@"^\d+.?\d{0,2}$", ErrorMessage = "Invalid hourly rate, maximum two decimal points.")]
    public decimal HourlyRate { get; set; }


    public CourtEditViewModel(Guid id, string courtNumber, decimal hourlyRate)
    {
        Id = id;
        HourlyRate = hourlyRate;
        CourtNumber = courtNumber;
    }

    public CourtEditViewModel()
    {
    }
}