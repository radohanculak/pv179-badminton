using System.ComponentModel.DataAnnotations;

namespace SprintMVC.Models.Identity;

public class LoginModel
{
    [Required]
    [Display(Name = "E-mail")]
    public string? Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string? Password { get; set; }

    public string? ReturnUrl { get; set; }
}
