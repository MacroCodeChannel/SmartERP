namespace SmartERP.Models
{
    public class Item : ModificationActivity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public SystemCodeDetail Category { get; set; }
        public int UnitofMeasureId { get; set; }
        public SystemCodeDetail UnitofMeasure { get; set; }
        public int StatusId { get; set; }
        public SystemCodeDetail Status { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitCost { get; set; }
        public string Notes { get; set; }

    }
}
