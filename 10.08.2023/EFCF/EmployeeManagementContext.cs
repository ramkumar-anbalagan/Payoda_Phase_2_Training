using EFCF.Model;
using Microsoft.EntityFrameworkCore;

namespace EFDBF
{
    internal class EmployeeManagementContext :DbContext
    {
        public DbSet<Dept> Depts { get; set; }

        public DbSet<Emp> Emps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source = MUNEESHKUMAR\\SQLEXPRESS; initial catalog = EmployeeManagement; integrated security=SSPI; TrustServerCertificate=True;");
        }
    }
}