using Microsoft.EntityFrameworkCore;
using Oder_Management.Models;

namespace Oder_Management.Data
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {

        }
        public DbSet<OrderList> OrderLists { get; set; }
    }
}
