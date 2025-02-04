using System.ComponentModel;

namespace SmartERP.Models
{
    public class SystemCode: ModificationActivity
    {
        public int Id { get; set; }

        [DisplayName("Code")]
        public string Code { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}
