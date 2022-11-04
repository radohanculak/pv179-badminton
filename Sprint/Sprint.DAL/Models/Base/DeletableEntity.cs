namespace Sprint.DAL.EFCore.Models.Base;

public abstract class DeletableEntity : BaseEntity
{
    public bool IsDeleted { get; set; }
}
