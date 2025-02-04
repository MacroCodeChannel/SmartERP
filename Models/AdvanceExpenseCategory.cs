namespace SmartERP.Models
{
    public class AdvanceExpenseCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal MinimumAmount { get; set; }
        public decimal MaximumAmount { get; set; }
    }
}
