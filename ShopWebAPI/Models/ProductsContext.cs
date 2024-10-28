using Microsoft.EntityFrameworkCore;

namespace ShopWebAPI.Models
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options) { }


        DbSet<Products> Products { get; set; }
        DbSet<ProductCategory> ProductCategories { get; set; }
        DbSet<State_product> StateProducts { get; set; }
        
    }
}
