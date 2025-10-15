using HR_Manager.Model;
using Microsoft.EntityFrameworkCore;

namespace HR_Manager.Context
{
    public class HrManagerContext : DbContext
    {
        public DbSet<Departament> Departaments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Salary> Salaries { get; set; }

        public HrManagerContext()
        {
        }

        public HrManagerContext(DbContextOptions<HrManagerContext> options)
        : base(options)
        {
        }

    }
}
