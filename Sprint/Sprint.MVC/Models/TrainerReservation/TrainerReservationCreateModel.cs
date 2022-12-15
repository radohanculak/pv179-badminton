using Sprint.BL.Dto.Trainer;

namespace Sprint.MVC.Models.TrainerReservation;

public class TrainerReservationCreateModel
{
    public Guid TrainerId { get; set; }

    public Guid CourtResId { get; set; }

    public DateTime TimeFrom { get; set; }

    public DateTime TimeTo { get; set; }
    
    // available trainers
    public IEnumerable<TrainerDto> TrainerDtos { get; set; }
}
