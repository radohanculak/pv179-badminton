using Sprint.BL.Dto.User;

namespace SprintMVC.Models.User;

public class UserIndexViewModel
{
    public IEnumerable<UserDto> Users { get; set; }
}