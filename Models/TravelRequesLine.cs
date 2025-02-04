namespace SmartERP.Models
{
    public class TravelRequesLine
    {
        public int Id { get; set; }
        public int TravelRequestHeaderId { get; set; }
        public TravelRequestHeader TravelRequestHeader { get; set; }
        public int UnitofMeasureId { get; set; }
        public SystemCodeDetail UnitofMeasure { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int Quantity { get; set; }
        public int Days { get; set; }
        public decimal UnitCost { get; set; }
        public decimal TotalCost { get; set; }
    }
}
