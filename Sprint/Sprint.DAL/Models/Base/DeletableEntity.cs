namespace Sprint.DAL.EFCore.Models.Base;

public class DeletableEntity : BaseEntity
{
    public bool IsDeleted { get; set; }
}
