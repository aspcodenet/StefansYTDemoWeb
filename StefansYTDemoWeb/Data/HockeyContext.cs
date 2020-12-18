using Microsoft.EntityFrameworkCore;

namespace StefansYTDemoWeb.Data
{
    public class HockeyContext : DbContext
    {
        public HockeyContext()
        {
            
        }
        public HockeyContext(DbContextOptions<HockeyContext> options)
            : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=localhost;initial catalog=hockey;integrated security=true");
            }
        }


        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

    }
}