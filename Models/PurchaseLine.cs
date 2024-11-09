namespace SmartERP.Models
{
    public class PurchaseLine
    {
        public int Id { get; set; }
        public int PurchaseHeaderId { get; set; }
        public PurchaseHeader PurchaseHeader { get; set; }
        public int TypeId { get; set; }
        public SystemCodeDetail Type { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalCost { get; set; }

    }
}
