using System.Data.Entity;

namespace TodoApps.Data
{
    public class AppDbContext : Dbcontext
    {
        public AppDbContext(DbContext<AppDbContext> options) 
        {
                
        }
    }
}
