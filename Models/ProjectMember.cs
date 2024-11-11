using Microsoft.AspNetCore.Identity;

namespace SmartERP.Models
{
    public class ProjectMember : ModificationActivity
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int RoleId { get; set; }
        public IdentityRole Role { get; set; }
    }
}
