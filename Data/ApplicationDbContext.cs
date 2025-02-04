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
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>()
            .Property(r => r.Name)
            .HasMaxLength(256);


            modelBuilder.Entity<IdentityRole>()
            .Property(r => r.NormalizedName)
            .HasMaxLength(256);

            modelBuilder.Entity<IdentityRole>()
           .Property(r => r.ConcurrencyStamp)
           .HasMaxLength(256);

            modelBuilder.Entity<OrderRequestLine>()
             .Property(b => b.UnitPrice)
              .HasPrecision(18, 3)
             .HasDefaultValueSql("00.000");

            modelBuilder.Entity<OrderRequestLine>()
             .Property(b => b.TotalPrice)
              .HasPrecision(18, 3)
             .HasDefaultValueSql("00.000");

            modelBuilder.Entity<TimeSheetLine>()
           .Property(b => b.TotalHours)
            .HasPrecision(18, 3)
           .HasDefaultValueSql("00.000");

            modelBuilder.Entity<PurchaseLine>()
           .Property(b => b.TotalCost)
            .HasPrecision(18, 3)
           .HasDefaultValueSql("00.000");

            modelBuilder.Entity<PurchaseLine>()
              .Property(b => b.UnitPrice)
              .HasPrecision(18, 3)
              .HasDefaultValueSql("00.000");

            modelBuilder.Entity<PurchaseHeader>()
            .Property(b => b.TotalAmount)
            .HasPrecision(18, 3)
            .HasDefaultValueSql("00.000");

            modelBuilder.Entity<SalesHeader>()
            .Property(b => b.TotalAmount)
            .HasPrecision(18, 3)
            .HasDefaultValueSql("00.000");


            modelBuilder.Entity<SalesLine>()
            .Property(b => b.UnitPrice)
            .HasPrecision(18, 3)
            .HasDefaultValueSql("00.000");

            modelBuilder.Entity<SalesLine>()
            .Property(b => b.TotalCost)
            .HasPrecision(18, 3)
            .HasDefaultValueSql("00.000");

            modelBuilder.Entity<TravelRequestHeader>()
           .Property(b => b.AdvanceAmount)
           .HasPrecision(18, 3)
           .HasDefaultValueSql("00.000");

            modelBuilder.Entity<TravelRequesLine>()
           .Property(b => b.TotalCost)
           .HasPrecision(18, 3)
           .HasDefaultValueSql("00.000");

            modelBuilder.Entity<TravelRequesLine>()
            .Property(b => b.UnitCost)
            .HasPrecision(18, 3)
            .HasDefaultValueSql("00.000");

            modelBuilder.Entity<ProjectBudgetHeaderLines>()
              .Property(b => b.UnitCost)
              .HasPrecision(18, 3)
              .HasDefaultValueSql("00.000");

            modelBuilder.Entity<ProjectBudgetHeaderLines>()
            .Property(b => b.TotalCost)
            .HasPrecision(18, 3)
            .HasDefaultValueSql("00.000");

            modelBuilder.Entity<ProjectBudgetHeaderLines>()
            .Property(b => b.Quantity)
            .HasPrecision(18, 3)
            .HasDefaultValueSql("00.000");

            modelBuilder.Entity<OrderRequest>()
           .Property(b => b.OrderAmount)
           .HasPrecision(18, 3)
           .HasDefaultValueSql("00.000");

            modelBuilder.Entity<OrderRequest>()
            .Property(b => b.PaidAmount)
            .HasPrecision(18, 3)
            .HasDefaultValueSql("00.000");

            modelBuilder.Entity<Contract>()
           .Property(b => b.Days)
           .HasPrecision(18, 3)
           .HasDefaultValueSql("00.000");

            modelBuilder.Entity<Contract>()
           .Property(b => b.Months)
           .HasPrecision(18, 3)
           .HasDefaultValueSql("00.000");

            modelBuilder.Entity<Payment>()
            .Property(b => b.Amount)
            .HasPrecision(18, 3)
            .HasDefaultValueSql("00.000");

            modelBuilder.Entity<PurchaseLine>()
            .Property(b => b.Quantity)
            .HasPrecision(18, 3)
            .HasDefaultValueSql("00.000");


            modelBuilder.Entity<Payment>()
           .Property(b => b.TransferCharges)
           .HasPrecision(18, 3)
           .HasDefaultValueSql("00.000");


            modelBuilder.Entity<PaymentLine>()
            .Property(b => b.TotalAmount)
            .HasPrecision(18, 3)
            .HasDefaultValueSql("00.000");

            modelBuilder.Entity<ContractDeliverable>()
            .Property(b => b.Days)
            .HasPrecision(18, 3)
            .HasDefaultValueSql("00.000");
            modelBuilder.Entity<Contract>()
            .Property(b => b.LumpsumAmount)
            .HasPrecision(18, 3)
            .HasDefaultValueSql("00.000");

            modelBuilder.Entity<Contract>()
           .Property(b => b.DailyRate)
           .HasPrecision(18, 3)
           .HasDefaultValueSql("00.000");

            modelBuilder.Entity<Contract>()
           .Property(b => b.MonthlyRate)
           .HasPrecision(18, 3)
           .HasDefaultValueSql("00.000");

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
        public DbSet<NumberSeriesSetup> NumberSeriesSetups { get; set; }
        public DbSet<OrderRequest> OrderRequests { get; set; }
        public DbSet<OrderRequestLine> OrderRequestLines { get; set; }
        public DbSet<SalesHeader> SalesHeaders { get; set; }
        public DbSet<SalesLine> SalesLines { get; set; }
        public DbSet<SystemSetting> SystemSettings { get; set; }
        public DbSet<ApprovalEntry> ApprovalEntries { get; set; }
        public DbSet<TravelRequestHeader> TravelRequestHeaders { get; set; }
        public DbSet<TravelRequesLine> TravelRequesLines { get; set; }
        public DbSet<TravelRequestMember> TravelRequestMembers { get; set; }
        public DbSet<ProjectBudgetCategory> ProjectBudgetCategories { get; set; }
        public DbSet<ProjectBudgetHeader> ProjectBudgetHeaders { get; set; }
        public DbSet<ProjectBudgetHeaderLines> ProjectBudgetHeaderLines { get; set; }
        public DbSet<ProjectBudgetLine> ProjectBudgetLines { get; set; }
        public DbSet<ProjectBudgetItem> ProjectBudgetItems { get; set; }
        public DbSet<GoodsReceivedNoteHeader> GoodsReceivedNoteHeaders { get; set; }
        public DbSet<GoodsReceivedNoteLine> GoodsReceivedNoteLines { get; set; }
        public DbSet<SystemTask> SystemRights { get; set; }
        public DbSet<UserRoleProfile> RoleProfiles { get; set; }
        public DbSet<ProjectPhase> ProjectPhases { get; set; }
        public DbSet<ProjectMilestone> ProjectMilestones { get; set; }
        public DbSet<ContractDeliverable> ContractDeliverables { get; set; }

    }
}
