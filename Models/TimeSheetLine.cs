namespace SmartERP.Models
{
    public class TimeSheetLine
    {
        public int Id { get; set; }
        public int TimeSheetId { get; set; }
        public TimeSheet TimeSheet { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int DayTypeId { get; set; }
        public SystemCodeDetail DayType { get; set; }

        public int ProjectRoleId { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
