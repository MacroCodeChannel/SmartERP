namespace SmartERP.Models
{
    public class ProjectLocation : ModificationActivity
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
}
