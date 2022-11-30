using Sprint.BL.Dto.Court;

namespace SprintMVC.Models.Court;

public class CourtIndexViewModel
{
    public IEnumerable<CourtDto> Courts { get; set; }
}