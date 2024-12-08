namespace SmartERP.Models
{
    public class OrderRequestLine
    {
        public int Id { get; set; }
        public int OrderRequestId { get; set; }
        public OrderRequest OrderRequest { get; set; }
        public int? ItemId { get; set; }
        public Item Item { get; set; }
        public string ItemDescription { get; set; }
        public int? Days { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int UnitOfMeasureId { get; set; }
        public SystemCodeDetail UnitOfMeasure { get; set; }
    }
}
