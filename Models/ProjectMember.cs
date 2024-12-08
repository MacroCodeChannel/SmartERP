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
        public int? ReportsToId { get; set; }
        public ProjectMember ReportsTo { get; set; }
        public int? ConsultantId { get; set; }
        public Consultant Consultant { get; set; }
        public int? ContractId { get; set; }
        public Consultant Contract { get; set; }
    }
}
