using Microsoft.EntityFrameworkCore;
using ShopWebAPI.Models;
using ShopWebAPI.Repositories;

namespace ShopWebAPI.Services
{
    public class RepositoryProducts : IProductsRepository<Products>
    {
         ProductsContext _dbContext;

        public RepositoryProducts(ProductsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Products>> getAllProducts() =>
            await _dbContext.Products
                .Include(p => p.ProductCategory)  // Asegúrate de que se incluye el Category
                .Include(p => p.StateProduct)      // Asegúrate de que se incluye el State
                .ToListAsync();


        public async Task<Products> GetProductById(int IdProduct) => await _dbContext.Products.FindAsync(IdProduct);

        public async Task AddProduct(Products product)
        {
            _dbContext.Products.Add(product);
            await _dbContext.SaveChangesAsync();  // Guarda los cambios en la base de datos de manera asíncrona

        }

        public async Task UpdateProduct(Products product)
        {
            _dbContext.Products.Attach(product);
            _dbContext.Entry(product).State = EntityState.Modified;

            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteProduct(Products product)
        {
            _dbContext.Remove(product);
            await _dbContext.SaveChangesAsync();  // Guarda los cambios en la base de datos de manera asíncrona
        }

        public async Task save() => await _dbContext.SaveChangesAsync();

    }
}
