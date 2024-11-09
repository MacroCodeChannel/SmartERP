using System.ComponentModel;

namespace SmartERP.Models
{
    public class Bank: ModificationActivity
    {
        public int Id { get; set; }

        [DisplayName("Bank Code")]
        public string Code { get; set; }

        [DisplayName("Bank Name")]
        public string Name { get; set; }

        [DisplayName("Bank Address")]
        public string Address { get; set; }

        [DisplayName("International Bank Account Number")]
        public string IBAN { get; set; }


        [DisplayName("SWIFT Code")]
        public string SWIFTCode { get; set; }

    }
}
