using Microsoft.AspNetCore.Identity;
using System.ComponentModel;

namespace SmartERP.Models
{
    public class CreationActivity
    {
        [DisplayName("Created By")]
        public string CreatedById { get; set; }
        public IdentityUser CreatedBy { get; set; }
        [DisplayName("Created On")]
        public DateTime? CreatedOn { get; set; }
    }
    public class ModificationActivity : CreationActivity
    {
        [DisplayName("Modified By")]
        public string? ModifiedById { get; set; }
        public IdentityUser ModifiedBy { get; set; }

        [DisplayName("Modified On")]
        public DateTime? ModifiedOn { get; set; }
    }

    public class ApprovalActivity : ModificationActivity
    {
        [DisplayName("Approved By")]
        public string? ApprovedById { get; set; }
        public IdentityUser ApprovedBy { get; set; }
        [DisplayName("Approved On")]
        public DateTime? ApprovedOn { get; set; }
    }
}
