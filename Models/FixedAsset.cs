namespace SmartERP.Models
{
    public class FixedAsset: ModificationActivity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public SystemCodeDetail Category { get; set; }
        public int StatusId { get; set; }
        public SystemCodeDetail Status { get; set; }
        public int ResponsibleEmployeeId { get; set; }
        public Employee ResponsibleEmployee { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public string SerialNumber { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
}
