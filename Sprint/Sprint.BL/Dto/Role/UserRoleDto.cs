using Sprint.Common.Enums;

namespace Sprint.BL.Dto.Role;

public class UserRoleDto
{
    public UserRole Role { get; set; }
    
    public static implicit operator UserRole(UserRoleDto wrapper) => wrapper.Role;
    public static implicit operator UserRoleDto(UserRole value) => new UserRoleDto() { Role = value };
}