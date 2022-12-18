using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Sprint.Common.Enums;

namespace SprintMVC.Models.Identity;

public class RegisterModel
{
    [Required]
    [StringLength(64)]
    [Display(Name = "First Name")]
    public string? FirstName { get; set; }
    
    [Required]
    [StringLength(64)]
    [Display(Name = "Last Name")]
    public string? LastName { get; set; }

    [Required]
    [EmailAddress]
    [Display(Name = "E-mail")]
    public string? Email { get; set; }
    
    [Required]
    [DataType(DataType.Date)]
    [Display(Name = "Date of Birth")]
    [BindProperty]
    public DateTime? DateOfBirth { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 4)]
    // "([a-zA-Z]+[^a-zA-Z]+|[^a-zA-Z]+[a-zA-Z]+).*"
    [RegularExpression(@"([a-zA-Z]+)*", ErrorMessage = "The password is not complex enough")]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string? Password { get; set; }

    // [DataType(DataType.Password)]
    // [Display(Name = "Confirm password")]
    // [Compare(nameof(Password))]
    // public string? ConfirmPassword { get; set; }

    public UserRole? Role { get; set; }

    public string? ReturnUrl { get; set; }
}