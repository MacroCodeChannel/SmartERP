namespace SmartERP.Models
{
    public class Contract :ModificationActivity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int ContractTypeId { get; set; }
        public SystemCodeDetail ContractType { get; set; }
        public int CompensationPackageId { get; set; }
        public SystemCodeDetail CompensationPackage { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int ConsultantId { get; set; }
        public Employee Consultant { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalHours { get; set; }
        public int OrderId { get; set; }
        public Payment Order { get; set; }
        public string Description { get; set; }
        public int ContractLeadId { get; set; }
        public Employee ContractLead { get; set; }
    }
}
