using Microsoft.EntityFrameworkCore;


namespace CentralDashboard.Models
{
    public class LogContext : DbContext
    {
        public LogContext()
        {
        }

        public LogContext(DbContextOptions opts) : base(opts)
        {
        }
        public DbSet<LogDB> LogsDB { get; set; }
        public DbSet<LogSum> LogSum { get; set; }


    }
}
