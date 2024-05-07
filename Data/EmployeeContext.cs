using EmployeeMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMVC.Data
{
    public class EmployeeContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(employee =>
            {
                employee.HasKey(e => e.EmployeeId);
                employee.Property(e => e.Name).IsRequired();
                employee.Property(e => e.Title).IsRequired();
            });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=EmployeeDB;trusted_connection=True;TrustServerCertificate=True");
        }
    }
}
