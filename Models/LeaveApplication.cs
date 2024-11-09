using System.ComponentModel.DataAnnotations;

namespace SmartERP.Models
{
    public class LeaveApplication : ModificationActivity
    {
        public int Id { get; set; }

        [Display(Name = "Employee Name")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [Display(Name = "Leave Days")]
        public int NoOfDays { get; set; }

        [Display(Name = "Start Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Leave Duration")]
        public int DurationId { get; set; }
        public SystemCodeDetail Duration { get; set; }

        [Display(Name = "Leave Type")]
        public int LeaveTypeId { get; set; }
        public SystemCodeDetail LeaveType { get; set; }
        public string? Attachment { get; set; }

        [Display(Name = "Notes")]
        public string Description { get; set; }

        [Display(Name = "Status")]
        public int StatusId { get; set; }
        public SystemCodeDetail Status { get; set; }

        public int? RelieverId { get; set; }
        public Employee Reliever { get; set; }

    }
}

