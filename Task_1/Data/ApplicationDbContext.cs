using Microsoft.EntityFrameworkCore;
using Task_1.Models;

namespace Task_1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employees {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Company_Employees;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
