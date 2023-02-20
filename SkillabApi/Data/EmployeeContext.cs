using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace SkillabApi.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
       : base(options)
        {
        }

        public DbSet<Employee> employees { get; set; }

    }
}
