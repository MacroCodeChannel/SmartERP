namespace SmartERP.Models
{
    public class ContractDeliverable
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public Contract Contract { get; set; }
        public string TaskName { get; set; }
        public decimal Days { get; set; }
    }
}
