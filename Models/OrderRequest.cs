namespace SmartERP.Models
{
    public class OrderRequest:ModificationActivity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime DateRequired { get; set; }
        public int StatusId { get; set; }
        public SystemCodeDetail Status { get; set; }    
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int? OrderTypeId { get; set; }
        public SystemCodeDetail OrderType { get; set; }
        public decimal OrderAmount { get; set; }
        public decimal PaidAmount { get; set; }

    }
}
