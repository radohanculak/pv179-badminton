using System.ComponentModel.DataAnnotations;
using Sprint.BL.Dto.User;

namespace SprintMVC.Models.User;

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

    
    public UserUpsertModel(Guid id, string firstName, string lastName, string email)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    public UserUpsertModel()
    {
        
    }
}