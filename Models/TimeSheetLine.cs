namespace SmartERP.Models
{
    public class TimeSheetLine
    {
        public int Id { get; set; }
        public int TimeSheetId { get; set; }
        public TimeSheet TimeSheet { get; set; }
        public decimal TotalHours { get; set; }
        public int? ProjectId { get; set; }
        public Project Project { get; set; }
        public int? LocationId { get; set; }
        public Location Location { get; set; }
        public string Comments { get; set; }
        public DateTime ActivityDate { get; set; }
        //Apply Leave Considerations // Lock the System Such that no one can work .

    }
}
