using Sprint.BL.Dto.User;

namespace Sprint.MVC.Models.User;

public class UserInfoViewModel
{
    public UserDto User { get; set; }

    public UserInfoViewModel(UserDto user)
    {
        User = user;
    }
}
