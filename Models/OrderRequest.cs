namespace SmartERP.Models
{
    public class OrderRequest:ModificationActivity
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public string Description { get; set; }
        public DateTime DateRequired { get; set; }
        public int StatusId { get; set; }
        public SystemCodeDetail Status { get; set; }    
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
