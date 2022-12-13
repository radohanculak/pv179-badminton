using System.ComponentModel.DataAnnotations;

namespace Sprint.DAL.EFCore.Models.Base;

public abstract class BaseEntity
{
    [Key]
    public Guid Id { get; set; }
    
    public bool IsDeleted { get; set; }
}
