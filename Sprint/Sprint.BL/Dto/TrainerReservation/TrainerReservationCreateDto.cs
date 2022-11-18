namespace Sprint.BL.Dto.TrainerReservation;

public class TrainerReservationCreateDto
{
    public Guid CourtReservationId { get; set; }

    public Guid TrainerId { get; set; }

    public bool IsDeleted { get; set; } = false;
}
