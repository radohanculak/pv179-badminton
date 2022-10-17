using System.ComponentModel.DataAnnotations;

namespace Sprint.DAL.Models;

public class BaseEntity
{
    [Key]
    public int Id { get; set; }
}
