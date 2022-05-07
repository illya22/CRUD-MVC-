using Microsoft.EntityFrameworkCore;
namespace CRUD_MVC_.Models
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Report> Reports { get; set; }

    }
}
