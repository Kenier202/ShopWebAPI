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

        public async Task<IEnumerable<Products>> getAllProducts() =>  await _dbContext.Products.ToListAsync();
        public async Task<Products> GetProductById(int IdProduct) => await _dbContext.Products.FindAsync(IdProduct);
        public async Task AddProduct(Products product) =>  _dbContext.Products.Add(product);
        public Task UpdateProduct(Products product)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteProduct(Products product) =>  _dbContext.Remove(product);
        public async Task save() => await _dbContext.SaveChangesAsync();

    }
}
