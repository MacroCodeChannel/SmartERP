using Microsoft.AspNetCore.Identity;
using System.ComponentModel;

namespace SmartERP.Models
{
    public class UserRoleProfile :ModificationActivity
    {
        public int Id { get; set; }

        [DisplayName("System Task")]
        public int TaskId { get; set; }
        public SystemTask Task { get; set; }

        [DisplayName("System Role")]
        public string? RoleId { get; set; }
        public IdentityRole Role { get; set; }
    }
}
