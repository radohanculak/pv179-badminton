using Sprint.BL.Dto.Court;

namespace Sprint.MVC.Models.Court;

public class CourtIndexViewModel
{
    public IEnumerable<CourtDto> Courts { get; set; }
}