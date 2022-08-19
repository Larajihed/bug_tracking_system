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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Bug> Bugs { get; set; }
 


    }
}
