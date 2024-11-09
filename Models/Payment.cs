namespace SmartERP.Models
{
    public class Payment : ModificationActivity
    {
        public int Id { get; set; }
        public string DocumentNo { get; set; }
        public int DocumentTypeId { get; set; }
        public SystemCodeDetail DocumentType { get; set; }

        public int PaymentModeId { get; set; }
        public SystemCodeDetail PaymentMode { get; set; }

        public int PaymentStatusId { get; set; }
        public SystemCodeDetail PaymentStatus { get; set; }

        public string ChequeNo { get; set; }
        public DateTime ChequeDate { get; set; }

        public decimal TotalAmount { get; set; }
        public int CurrencyTypeId { get; set; }
        public SystemCodeDetail CurrencyType { get; set; }
    }
}
