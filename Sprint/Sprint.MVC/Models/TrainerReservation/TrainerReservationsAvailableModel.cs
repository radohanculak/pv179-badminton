using Sprint.BL.Dto.Trainer;

namespace Sprint.MVC.Models.TrainerReservation;

public class TrainerReservationsAvailableModel
{
    public IEnumerable<TrainerDto> TrainerDtos { get; set; }
}
