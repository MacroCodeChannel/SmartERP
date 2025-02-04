namespace SmartERP.Models
{
    public class GoodsReceivedNoteLine
    {
        public int Id { get; set; }
        public int GRNHeaderId { get; set; }
        public GoodsReceivedNoteHeader GRNHeader { get; set; }
        public int UnitofMeasureId { get; set; }
        public SystemCodeDetail UnitofMeasure { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int Quantity { get; set; }
        public string Comments { get; set; }
    }
}
