namespace SmartERP.Models
{
    public class ProjectPhase :ModificationActivity
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
