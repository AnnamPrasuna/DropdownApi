using Microsoft.EntityFrameworkCore;
using OneToOneRelDropdownApi.Models;
using System.Security.Cryptography.Xml;

namespace OneToOneRelDropdownApi.Data
{
    public class EmpAddContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Addresss> Address { get; set; }
        public EmpAddContext(DbContextOptions<EmpAddContext> options):base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Address)
                .WithOne(a => a.Employee)
                .HasForeignKey<Employee>(d => d.AddressId);

            modelBuilder.Entity<Addresss>()
                .HasKey(f => f.AddressId);
        }
    }
}
