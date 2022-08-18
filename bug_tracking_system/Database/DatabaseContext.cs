using bug_tracking_system.Models;
using Microsoft.EntityFrameworkCore;

namespace bug_tracking_system.Database
{
    public class DatabaseContext: DbContext
    {
        protected readonly IConfiguration Configuration;

        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
         
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Bug> Bugs { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Severity> Severities { get; set; }
        public DbSet<Status> Status { get; set; }


    }
}
