using ShopWebAPI.Models;
using ShopWebAPI.Repositories;

namespace ShopWebAPI.Services
{
    public class RepositoryProducts : ShopWebRepository<Products>
    {
        private ProductCategory dbContext;

        public RepositoryProducts(ProductCategory dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<IEnumerable<Products>> getAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task<Products> GetProductById()
        {
            throw new NotImplementedException();
        }
        public Task AddProduct(Products product)
        {
            throw new NotImplementedException();
        }
        public Task UpdateProduct(Products product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProduct(Products product)
        {
            throw new NotImplementedException();
        }
        public Task save()
        {
            throw new NotImplementedException();
        }
    }
}
