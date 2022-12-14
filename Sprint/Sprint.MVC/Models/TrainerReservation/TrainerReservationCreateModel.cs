using Sprint.BL.Dto.Trainer;

namespace Sprint.MVC.Models.TrainerReservation;

public class TrainerReservationCreateModel
{
    public Guid UserId { get; set; }

    public Guid TrainerId { get; set; }

    public Guid CourtId { get; set; }

    public DateTime TimeFrom { get; set; }

    public DateTime TimeTo { get; set; }
    
    // available trainers
    public IEnumerable<TrainerDto> TrainerDtos { get; set; }
}
