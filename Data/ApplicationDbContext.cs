using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartERP.Models;

namespace SmartERP.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Office> Offices { get; set; }
        public DbSet<SystemCode> SystemCodes { get; set; }
        public DbSet<SystemCodeDetail> SystemCodeDetails { get; set; }
        public DbSet<WorkFlowUserGroup> WorkFlowUserGroups { get; set; }
        public DbSet<WorkFlowUserGroupMember> WorkFlowUserGroupMembers { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Consultant> Consultants { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Item> Ite { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}
