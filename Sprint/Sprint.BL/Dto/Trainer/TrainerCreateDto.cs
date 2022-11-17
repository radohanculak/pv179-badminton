namespace Sprint.BL.Dto.Trainer;

public class TrainerCreateDto
{
    public Guid UserId { get; set; }

    public decimal HourlyRate { get; set; }

    public string? Description { get; set; }
}
