using Microsoft.EntityFrameworkCore;
using StudentDetailsDBF.Models;

namespace StudentDetailsDBF.Context
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        
    }
}
