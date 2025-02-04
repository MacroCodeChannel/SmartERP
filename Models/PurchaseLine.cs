namespace SmartERP.Models
{
    public class PurchaseLine
    {
        public int Id { get; set; }
        public int PurchaseHeaderId { get; set; }
        public PurchaseHeader PurchaseHeader { get; set; }
        public int UnitofMeasureId { get; set; }
        public SystemCodeDetail UnitofMeasure { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalCost { get; set; }
        public int? TimesheetLineId { get; set; }
        public TimeSheetLine TimesheetLine { get; set; }

    }
}
