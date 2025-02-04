namespace SmartERP.Models
{
    public class PaymentLine
    {
        public int Id { get; set; }
        public int PaymentId { get; set; }
        public Payment Payment { get; set; }
        public string ItemName { get; set; }
        public decimal TotalAmount { get; set; }

    }
}
