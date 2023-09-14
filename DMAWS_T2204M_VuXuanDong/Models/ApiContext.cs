using Microsoft.EntityFrameworkCore;

namespace DMAWS_T2204M_VuXuanDong.Models
{
    public class ApiContext:DbContext
    {
        public ApiContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<ProjectEmployee> ProjectEmployees { get; set; }
    }
}
