namespace SmartERP.Models
{
    public class PaymentLine
    {
        public int Id { get; set; }
        public int PaymentId { get; set; }
        public Payment Payment { get; set; }

        public int ItemTypeId { get; set; }
        public Payment ItemType { get; set; }

        public int ItemId { get; set; }

        public Payment Item { get; set; }

    }
}
