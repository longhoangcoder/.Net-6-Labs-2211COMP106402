using Microsoft.EntityFrameworkCore;
using RazorPagesDemoApp.Model.Domain;

namespace RazorPagesDemoApp.Data
{
    public class RazorPagesDemoDbContext: DbContext
    {
        public RazorPagesDemoDbContext(DbContextOptions options): base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }


}
