namespace SmartERP.Models
{
    public class ProjectPaymentPlan
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int MilestoneId { get; set; }
        public ProjectMilestone Milestone { get; set; }
        public DateTime DueDate { get; set; }
        public decimal ContractualAmount { get; set; }
        public string Condition { get; set; }
    }
}
