using Microsoft.EntityFrameworkCore;
using OderMangement.Models;

namespace OderMangement.Data
{
    public class OrderDbContext:DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {
               
        }
        public DbSet<OrderList> OrderLists { get; set; }
    }
}
