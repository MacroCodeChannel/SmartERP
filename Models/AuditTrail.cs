namespace SmartERP.Models
{
    public class AuditTrail : ModificationActivity
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public int RecordId { get; set; }
        public string ActionType { get; set; }
        public string IPAddress { get; set; }


    }
}
