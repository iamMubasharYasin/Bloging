using Bloging.Models;
using Microsoft.EntityFrameworkCore;

namespace Bloging.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Student> tbl_Std { get; set; }
    }
}
