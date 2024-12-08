namespace SmartERP.Models
{
    public class Project :ModificationActivity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int ProjectLeadId { get; set; }
        public Employee ProjectLead { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ProjectAdminId { get; set; }
        public Employee ProjectAdmin { get; set; }
        public int ProjectTypeId { get; set; }
        public SystemCodeDetail ProjectType { get; set; }
        public int StatusId { get; set; }
        public SystemCodeDetail Status { get; set; }

    }
}
