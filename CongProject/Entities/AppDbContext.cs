using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;

namespace CongProject.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(string connectionString) : base(connectionString) 
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDbContext, Migrations.Configuration>());
        }
        public AppDbContext() : base("Server=.;Database=MyDb;Trusted_Connection=True;")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDbContext, Migrations.Configuration>());
        }
        public DbSet<tblAccount> tblAccounts { get; set; }
        public DbSet<tblComponent> tblComponents { get; set; }
        public DbSet<tblComponentType> tblComponentTypes { get; set; }
        public DbSet<tblLog> tblLogs { get; set; }
        public DbSet<tblPermission> tblPermissions { get; set; }
        public DbSet<tblPlan> tblPlans { get; set; }
        public DbSet<tblReport> tblReports { get; set; }
        public DbSet<tblResource> tblResources { get; set; }
        public DbSet<tblRisk> tblRisks { get; set; }
        public DbSet<tblRole> tblRoles { get; set; }
        public DbSet<tblSolution> tblSolutions { get; set; }
        public DbSet<tblUser> tblUsers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
