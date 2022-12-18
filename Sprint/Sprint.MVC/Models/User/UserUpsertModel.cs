using Sprint.Common.Enums;
using System.ComponentModel.DataAnnotations;

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
    
    public string? PhotoPath { get; set; }

    public UserRole Role { get; set; }
    
    public UserRole OldRole { get; set; }


    public UserUpsertModel(Guid id, string firstName, string lastName, string email, UserRole role, string? photoPath)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Role = role;
        OldRole = role;
        PhotoPath = photoPath;
    }

    public UserUpsertModel()
    {
        
    }
}