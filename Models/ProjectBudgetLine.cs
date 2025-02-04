namespace SmartERP.Models
{
    public class ProjectBudgetLine : ModificationActivity
    {
        public int Id { get; set; }
        public int BudgetCategoryId { get; set; }
        public ProjectBudgetCategory BudgetCategory { get; set; }
        public string Name { get; set; }
    }
}
