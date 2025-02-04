namespace SmartERP.Models
{
    public class SystemTask : ModificationActivity
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public int? ParentId { get; set; }

        public SystemTask Parent { get; set; }

        public ICollection<SystemTask> ChildTasks { get; }

        public int? OrderNumber { get; set; }

    }
}
