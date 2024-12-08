namespace SmartERP.Models
{
    public class NumberSeriesSetup :ModificationActivity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Prefix { get; set; }
        public int TypeId { get; set; }
        public SystemCodeDetail Type { get; set; }
        public string FirstSerialNo { get; set; }
        public int StatusId { get; set; }
        public SystemCodeDetail Status { get; set; }


    }
}
