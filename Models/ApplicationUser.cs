using Microsoft.AspNetCore.Identity;
using System.ComponentModel;

namespace SmartERP.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }


        [DisplayName("Gender")]
        public int? GenderId { get; set; }
        public SystemCodeDetail Gender { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string FullName => $"{FirstName} {MiddleName} {LastName}";


        [DisplayName("Role Name")]
        public string RoleId { get; set; }

        public IdentityRole Role { get; set; }

        [DisplayName("Is Locked")]
        public bool? IsLocked { get; set; }

        [DisplayName("User Type")]
        public int UserTypeId { get; set; }

        public SystemCodeDetail UserType { get; set; }
    }
}

