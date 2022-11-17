using Sprint.BL.Dto.CourtReservation;
using Sprint.BL.Dto.Trainer;
using Sprint.BL.Dto.TrainerReview;

namespace Sprint.BL.Dto.TrainerReservation;

public class TrainerReservationDto
{
    public Guid Id { get; set; }

    public CourtReservationDto CourtReservation { get; set; } = null!;
    
    public TrainerDto Trainer { get; set; } = null!;

    public TrainerReviewDto? TrainerReview { get; set; } = null;

    public bool IsDeleted { get; set; } = false;
}
