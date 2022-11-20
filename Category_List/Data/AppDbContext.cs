using Category_List.Model;
using Microsoft.EntityFrameworkCore;

namespace Category_List.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }    
    }
}
