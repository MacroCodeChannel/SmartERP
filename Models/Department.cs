using System.ComponentModel;

namespace SmartERP.Models
{
    public class Department:ModificationActivity
    {
        [DisplayName("No")]
        public int Id { get; set; }


        [DisplayName("Department Code")]
        public string Code { get; set; }


        [DisplayName("Department Name")]
        public string Name { get; set; }
    }
}
