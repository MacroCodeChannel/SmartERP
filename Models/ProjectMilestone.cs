namespace SmartERP.Models
{
    public class ProjectMilestone : ModificationActivity
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int PhaseId { get; set; }
        public ProjectPhase Phase { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? CompletionDate { get; set; }
    }
}
