namespace SmartERP.Models
{
    public class Experience : ModificationActivity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int? ConsultantId { get; set; }
        public Consultant Consultant { get; set; }
    }
}
