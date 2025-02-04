using System.ComponentModel;

namespace SmartERP.Models
{
    public class Office:ModificationActivity
    {
        [DisplayName("No")]
        public int Id { get; set; }


        [DisplayName("Office Code")]
        public string Code { get; set; }


        [DisplayName("Office Name")]
        public string Name { get; set; }

        [DisplayName("Is Active")]
        public bool IsActive { get; set; }
    }
}
