using Microsoft.EntityFrameworkCore;
using uniqilo.Models;

namespace uniqilo.DataAcces
{
    public class AppDbContext  : DbContext
    {
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    }
}
