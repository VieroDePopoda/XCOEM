using Microsoft.EntityFrameworkCore;

namespace XCOEM.Models
{
    public class ProductsContext : DbContext
    {
        public DbSet<Products> Products { get; set; }

        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options)
        {
        }
    }
}