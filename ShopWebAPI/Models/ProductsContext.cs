using Microsoft.EntityFrameworkCore;

namespace ShopWebAPI.Models
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options) { }


        public DbSet<Products> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<State_product> StateProducts { get; set; }
        
    }
}
