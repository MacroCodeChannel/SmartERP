namespace SmartERP.Models
{
    public class ProjectBudgetItem : ModificationActivity
    {
        public int Id { get; set; }
        public int BudgetLineId { get; set; }
        public ProjectBudgetLine BudgetLine { get; set; }
        public string Name { get; set; }
    }
}
