using Sprint.Common.Enums;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc.Html;

namespace Sprint.MVC.Models.User;

public class UserUpsertModel
{
    public Guid Id { get; set; }

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }

    public UserRole Role { get; set; }

    
    public UserUpsertModel(Guid id, string firstName, string lastName, string email, UserRole role)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Role = role;
    }

    public UserUpsertModel()
    {
        
    }
}