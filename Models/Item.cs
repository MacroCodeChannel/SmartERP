namespace SmartERP.Models
{
    public class Item : ModificationActivity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int StatusId { get; set; }
        public SystemCodeDetail Status { get; set; }
        public int? BudgetItemId { get; set; }
        public ProjectBudgetItem BudgetItem { get; set; }

    }
}
