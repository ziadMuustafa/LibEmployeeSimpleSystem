using Microsoft.EntityFrameworkCore;

namespace ITI_GraduationProject.Models
{
    public class CompanyContext:DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-LCSB26T\\SQLEXPRESS;Database=itiGraduationProject;Trusted_connection=true;TrustServerCertificate=true");
        }
    }
}
