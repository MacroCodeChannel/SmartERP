namespace SmartERP.Models
{
    public class SalesLine
    {
        public int Id { get; set; }
        public int SalesHeaderId { get; set; }
        public SalesHeader SalesHeader { get; set; }
        public int UnitofMeasureId { get; set; }
        public SystemCodeDetail UnitofMeasure { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalCost { get; set; }
    }
}
