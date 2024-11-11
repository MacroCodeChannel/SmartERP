using Microsoft.AspNetCore.Identity;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable("Users");
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable("Roles");
                entity.HasKey(e => e.Id);
            });
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
        public DbSet<Item> Items { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentLine> PaymentLines { get; set; }
        public DbSet<ProjectLocation> ProjectLocations { get; set; }
        public DbSet<ProjectMember> ProjectMembers { get; set; }
        public DbSet<ProjectUpdate> ProjectUpdates { get; set; }
        public DbSet<PurchaseHeader> PurchaseHeaders { get; set; }
        public DbSet<PurchaseLine> PurchaseLines { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<TimeSheet> TimeSheets { get; set; }
        public DbSet<TimeSheetLine> TimeSheetLines { get; set; }
        public DbSet<FixedAsset> FixedAssets { get; set; }
        public DbSet<LeaveApplication> LeaveApplications { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<AuditTrail> AuditTrails { get; set; }
    }
}
