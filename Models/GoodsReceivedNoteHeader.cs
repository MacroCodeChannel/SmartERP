namespace SmartERP.Models
{
    public class GoodsReceivedNoteHeader :ModificationActivity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int PurchaseHeaderId { get; set; }
        public PurchaseHeader PurchaseHeader { get; set; }
        public int StatusId { get; set; }
        public SystemCodeDetail Status { get; set; }
        public DateTime ReceivedDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int ReceiptLocationId { get; set; }
        public Location ReceiptLocation { get; set; }
        public ICollection<GoodsReceivedNoteLine> GoodsReceivedNoteLines { get; set; }
    }
}
