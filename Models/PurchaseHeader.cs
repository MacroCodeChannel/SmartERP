namespace SmartERP.Models
{
    public class PurchaseHeader: ModificationActivity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? VendorId { get; set; }
        public Vendor Vendor { get; set; }
        public int? ProjectId { get; set; }
        public Project Project { get; set; }
        public int PurchaseTypeId { get; set; }
        public SystemCodeDetail PurchaseType { get; set; }
        public int DocumentTypeId { get; set; }
        public SystemCodeDetail DocumentType { get; set; }
        public int? OrderId { get; set; }
        public OrderRequest Order { get; set; }
        public int StatusId { get; set; }
        public SystemCodeDetail Status { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int? DeliveryLocationId { get; set; }
        public Location DeliveryLocation { get; set; }
        public ICollection<PurchaseLine> PurchaseLines { get; set; }
        public int? ConsultantId { get; set; }
        public Consultant Consultant { get; set; }
        public int? PurchasHeaderId { get; set; }
        public PurchaseHeader PurchasHeader { get; set; }
    }
}
