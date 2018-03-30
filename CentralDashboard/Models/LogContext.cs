using Microsoft.EntityFrameworkCore;


namespace CentralDashboard.Models
{
    public class LogContext : DbContext
    {
        public LogContext(DbContextOptions opts) : base(opts)
        {
        }
        public DbSet<LogDB> LogsDB { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

    }
}
