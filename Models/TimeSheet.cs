namespace SmartERP.Models
{
    public class TimeSheet:ModificationActivity
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int? ProjectId { get; set; }
        public Project Project { get; set; }
        public int? TimesheetTypeId { get; set; }
        public SystemCodeDetail TimesheetType { get; set; }
        public string Description { get; set; }
    }
}
