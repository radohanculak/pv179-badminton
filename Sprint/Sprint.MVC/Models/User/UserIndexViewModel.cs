using Sprint.BL.Dto.User;

namespace Sprint.MVC.Models.User;

public class UserIndexViewModel
{
    public IEnumerable<UserDto> Users { get; set; }
}