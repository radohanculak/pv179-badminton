using Sprint.BL.Dto.TrainerPhoto;
using Sprint.BL.Dto.User;

namespace Sprint.BL.Dto.Trainer;

public class TrainerDto
{
    public Guid Id { get; set; }
    
    public decimal HourlyRate { get; set; }

    public string? Description { get; set; }
    
    public UserDto User { get; set; } = null!;
    
    public List<TrainerPhotoDto> TrainerPhotos { get; set; } = null!;
}
