namespace SmartERP.Models
{
    public class TravelRequestMember
    {
        public int Id { get; set; }
        public int TravelRequestHeaderId { get; set; }
        public TravelRequestHeader TravelRequestHeader { get; set; }
        public int ProjectMemberId { get; set; }
        public ProjectMember ProjectMember { get; set; }
        public string PassportNo { get; set; }
        public string  SpecialInstruction { get; set; }
    }
}
