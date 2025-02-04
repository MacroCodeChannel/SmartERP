namespace SmartERP.Models
{
    public class Payment : ModificationActivity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int DocumentTypeId { get; set; }
        public int? ProjectId { get; set; }
        public Project Project { get; set; }
        public int? ConsultantId { get; set; }
        public Consultant Consultant { get; set; }
        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int? VendorId { get; set; }
        public Vendor Vendor { get; set; }
        public SystemCodeDetail DocumentType { get; set; }
        public int PaymentModeId { get; set; }
        public SystemCodeDetail PaymentMode { get; set; }
        public int StatusId { get; set; }
        public SystemCodeDetail Status { get; set; }
        public string? ChequeNo { get; set; }
        public DateTime? ChequeDate { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal TransferCharges { get; set; }
        public string PaymentDescription { get; set; }
        public int? InvoiceId { get; set; }
        public PurchaseHeader Invoice { get; set; }
    }
}
