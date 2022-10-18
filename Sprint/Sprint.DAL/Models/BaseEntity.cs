using System.ComponentModel.DataAnnotations;

namespace Sprint.DAL.EFCore.Models;

public class BaseEntity
{
    [Key]
    public Guid Id { get; set; }
}
