namespace Sprint.BL.Dto.TrainerReview;

public class TrainerReviewDto
{
    public Guid Id { get; set; }

    public int Rating { get; set; }

    public string Text { get; set; } = null!;

    public bool Hide { get; set; } = false;

    public Guid ReservationId { get; set; } 
    
    public bool IsDeleted { get; set; } = false;
}
