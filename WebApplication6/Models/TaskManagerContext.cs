using Microsoft.EntityFrameworkCore;

namespace UserManagement2.Models
{
    public class TaskManagerContext : DbContext
    {
        public TaskManagerContext(DbContextOptions<TaskManagerContext> options)
           : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; } = null!;
    }
}
