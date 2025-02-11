using Microsoft.EntityFrameworkCore;

namespace Coffer.Models
{
    public class CofferDBContext : DbContext
    {
        public CofferDBContext(DbContextOptions<CofferDBContext> options)
            : base(options) { }

        public DbSet<Coffer> Coffers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coffer>().HasNoKey(); // 👈 Mark as keyless
        }
    }
}
