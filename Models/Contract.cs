namespace SmartERP.Models
{
    public class Contract :ModificationActivity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int ContractTypeId { get; set; }
        public SystemCodeDetail ContractType { get; set; }
        public int CompensationPackageId { get; set; }
        public SystemCodeDetail CompensationPackage { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int ConsultantId { get; set; }
        public Consultant Consultant { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Days { get; set; }
        public decimal Months { get; set; }
        public int OrderId { get; set; }
        public OrderRequest Order { get; set; }
        public string Description { get; set; }
        public int ContractLeadId { get; set; }
        public ProjectMember ContractLead { get; set; }
        public int StatusId { get; set; }
        public SystemCodeDetail Status { get; set; }
        public int ProjectTitleId { get; set; }
        public SystemCodeDetail ProjectTitle { get; set; }
        public int LocationId { get; set; }
        public ProjectLocation Location { get; set; }
        public decimal? DailyRate { get; set; }
        public decimal? MonthlyRate { get; set; }
        public decimal? LumpsumAmount { get; set; }
    }
}
