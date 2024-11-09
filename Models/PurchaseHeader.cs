namespace SmartERP.Models
{
    public class PurchaseHeader: ModificationActivity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int PurchaseTypeId { get; set; }
        public SystemCodeDetail PurchaseType { get; set; }
        public int DocumentTypeId { get; set; }
        public SystemCodeDetail DocumentType { get; set; }
        public int CurrencyId { get; set; }
        public SystemCodeDetail Currency { get; set; }
        public int PaymentTermId { get; set; }
        public SystemCodeDetail PaymentTerm { get; set; }
        public int StatusId { get; set; }
        public SystemCodeDetail Status { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Notes { get; set; }
        public ICollection<PurchaseLine> PurchaseLines { get; set; }
    }
}
