namespace SmartERP.Models
{
    public class SalesHeader: ApprovalActivity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int DocumentTypeId { get; set; }
        public SystemCodeDetail DocumentType { get; set; }
        public int? ClientId { get; set; }
        public Client Client { get; set; }
        public int StatusId { get; set; }
        public SystemCodeDetail Status { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }
        public ICollection<SalesLine> SalesLines { get; set; }
    }
}
