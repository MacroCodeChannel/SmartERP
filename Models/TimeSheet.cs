namespace SmartERP.Models
{
    public class TimeSheet:ModificationActivity
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        public decimal TotalHours { get; set; }

        public int HourlyRateId { get; set; }
        public SystemCodeDetail HourlyRate { get; set; }
        public string Description { get; set; }
    }
}
