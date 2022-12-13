namespace Sprint.BL.Dto.TrainerPhoto;

public class TrainerPhotoDto
{
    public string Path { get; set; } = null!;
    public bool Hide { get; set; }
    public Guid TrainerId { get; set; }
    
    public bool IsDeleted { get; set; } = false;
}
