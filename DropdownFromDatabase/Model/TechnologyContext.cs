using Microsoft.EntityFrameworkCore;

namespace DropdownFromDatabase.Model
{
    public class TechnologyContext : DbContext
    {
        public TechnologyContext(DbContextOptions<TechnologyContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Technology>().ToTable("Technology");
        }

        public DbSet<Technology> technologies { get; set; }
    }
}
