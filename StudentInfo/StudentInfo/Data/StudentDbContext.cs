using Microsoft.EntityFrameworkCore;
using StudentInfo.Models;

namespace StudentInfo.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {

        }
        public DbSet<StudentInfoModel> StudentInfoModels { get; set; }
    }
}
