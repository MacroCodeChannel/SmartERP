namespace SmartERP.Models
{
    public class WorkFlowUserGroup : ModificationActivity
    {
        // Leave Applications//Imprest Application/Salary Advance Request
        public int Id { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public int? DepartmentId { get; set; }
        public Department Department { get; set; }

        public int? DocumentTypeId { get; set; }
        public SystemCodeDetail DocumentType { get; set; }
    }
}
