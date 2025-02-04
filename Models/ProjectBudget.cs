namespace SmartERP.Models
{
    public class ProjectBudgetHeader : ApprovalActivity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public string Remarks { get; set; }
    }
    public class ProjectBudgetHeaderLines 
    {
        public int Id { get; set; }
        public int HeaderId { get; set; }
        public ProjectBudgetHeader Header { get; set; }
        public int BudgetItemId { get; set; }
        public ProjectBudgetItem BudgetItem { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitCost { get; set; }
        public int Days { get; set; }
        public decimal TotalCost { get; set; }
    }
}
