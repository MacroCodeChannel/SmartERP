using System.ComponentModel;

namespace SmartERP.Models
{
    public class WorkFlowUserGroupMember : ModificationActivity
    {
        public int Id { get; set; }
        public int WorkFlowUserGroupId { get; set; }
        public WorkFlowUserGroup WorkFlowUserGroup { get; set; }

        [DisplayName("Document Sender")]
        public string SenderId { get; set; } 
        public ApplicationUser Sender { get; set; }

        [DisplayName("Document Approver")]
        public string ApproverId { get; set; } 
        public ApplicationUser Approver { get; set; }

        public int RoleId { get; set; }
        public SystemCodeDetail Role { get; set; }

        public int SequenceNo { get; set; }

        public int PriorityId { get; set; }
        public SystemCodeDetail Priority { get; set; }


    }
}
