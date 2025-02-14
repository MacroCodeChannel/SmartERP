﻿using System.ComponentModel;

namespace SmartERP.Models
{
    public class ApprovalEntry: ModificationActivity
    {
        public int Id { get; set; }

        [DisplayName("Record Id")]
        public int RecordId { get; set; } // Primary Key of the Document


        [DisplayName("Document Type")]
        public int DocumentTypeId { get; set; } //Leave Application,invoice,Leave Rejection
        public SystemCodeDetail DocumentType { get; set; }


        [DisplayName("Sequence No")]
        public int SequenceNo { get; set; } // 1,2,3,4,5,6 (Approvals)


        [DisplayName("Workflow User Group")]
        public int UserGroupMemberId { get; set; } 
        public WorkFlowUserGroupMember UserGroupMember { get; set; }

        [DisplayName("Approver Name")]
        public string ApproverId { get; set; } // 1,2,3,4,5,6 (Approvers), session user
        public ApplicationUser Approver { get; set; }


        [DisplayName("Status")]
        public int StatusId { get; set; } //Status of the document,pending approval/REJECT/APPROVE
        public SystemCodeDetail Status { get; set; }

        [DisplayName("Date Sent for Apporval")]
        public DateTime DateSentForApproval { get; set; } // Date sent for Approval

        [DisplayName("Last Modified On")]
        public DateTime LastModifiedOn { get; set; } // The Action of the Approvers

        [DisplayName("Last Modified By")]
        public string LastModifiedById { get; set; }
        public ApplicationUser LastModifiedBy { get; set; }

        [DisplayName("Comments")]
        public string Comments { get; set; }


        [DisplayName("Conroller Name")]
        public string ControllerName { get; set; }

        [DisplayName("Priority Type")]
        public int PriorityTypeId { get; set; } 
        public SystemCodeDetail PriorityType { get; set; }

        public string TableName { get; set; }

        public string DocumentNo { get; set; }
    }
}
