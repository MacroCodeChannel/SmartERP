﻿using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace SmartERP.Models
{
    public class Employee: ModificationActivity
    {
        public int Id { get; set; }
        public string EmpNo { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }


        [DisplayName("Last Name")]
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {MiddleName} {LastName}";

        [DisplayName("Phone Number")]
        public int PhoneNumber { get; set; }


        [DisplayName("Email Address")]

        public string EmailAddress { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }

        [DisplayName("Department Name")]
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }

        [DisplayName("Designation Name")]
        public int? DesignationId { get; set; }
        public Designation Designation { get; set; }


        [DisplayName("Gender Name")]
        public int? GenderId { get; set; }
        public SystemCodeDetail Gender { get; set; }


        [DisplayName("Employee Photo")]
        public string? Photo { get; set; }


        [DisplayName("Employment Date")]
        public DateTime? EmploymentDate { get; set; }

        public int? StatusId { get; set; }
        public SystemCodeDetail Status { get; set; }

        public DateTime? InactiveDate { get; set; }
        public int? CauseofInactivityId { get; set; }
        public SystemCodeDetail CauseofInactivity { get; set; }

        public DateTime? TerminationDate { get; set; }
        public int? TerminationReasonId{ get; set; }
        public SystemCodeDetail Reasonfortermination { get; set; }

        public int? BankId { get; set; }
        public Bank Bank { get; set; }


        [DisplayName("Company Email Address")]
        public string? CompanyEmail { get; set; }

        [DisplayName("Passport No")]
        public string? PassportNo { get; set; }


        [DisplayName("Employment Terms")]
        public int? EmploymentTermsId { get; set; }
        public SystemCodeDetail EmploymentTerms { get; set; }

        [DisplayName("Allocated Leave Balance")]
        public Decimal? AllocatedLeaveDays { get; set; }

        [DisplayName("Leave Balance")]
        public Decimal? LeaveOutStandingBalance { get; set; }

        [DisplayName("Pays Tax")]
        public bool? PaysTax { get; set; }

        [DisplayName("Disability Type")]
        public int? DisabilityId { get; set; }
        public SystemCodeDetail Disability { get; set; }

        public string? DisabilityCertificate { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }

    }
}
