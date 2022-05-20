using Microsoft.EntityFrameworkCore;
using TodoApps.Models;

namespace TodoApps.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<TodoList> TodoLists { get; set; }
    }
}
