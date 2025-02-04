namespace SmartERP.Models
{
    public class Location :ModificationActivity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int GradeId { get; set; }
        public SystemCodeDetail Grade { get; set; }
        public bool IsActive { get; set; }
    }
}
