namespace SmartERP.Models
{
    public class TravelRequestHeader:ApprovalActivity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public DateTime RequestDate { get; set; }
        public string Position { get; set; }
        public int ModeofTransportId { get; set; }

        public SystemCodeDetail ModeofTransport { get; set; }

        public int StatusId { get; set; }

        public SystemCodeDetail Status { get; set; }
        
        public int TravelDocumentTypeId { get; set; }
        public SystemCodeDetail TravelDocumentType { get; set; }
        public string TravelDocNo { get; set; }
        public decimal AdvanceAmount { get; set; }
        public string TravelReason { get; set; }
        public int DestinationFromId { get; set; }
        public Location DestinationFrom { get; set; }
        public int ArrivalToId { get; set; }
        public Location ArrivalTo { get; set; }
        public DateTime DepartureDate { get; set; }
        public string SpecialInstructions { get; set; }
        public string OtherTravelArrangements { get; set; }
    }
}
