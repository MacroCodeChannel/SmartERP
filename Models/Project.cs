namespace SmartERP.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int ProjectLeadId { get; set; }
        public Employee ProjectLead { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public string Description { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
