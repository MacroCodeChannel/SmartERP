namespace SmartERP.Models
{
    public class SystemSetting :ModificationActivity
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
