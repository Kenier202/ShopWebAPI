using ShopWebAPI.DTOs;
using ShopWebAPI.Interfaces;
using ShopWebAPI.Models;
using ShopWebAPI.Repositories;

namespace ShopWebAPI.Services
{
    public class ProductsService : IProductsService
    {
        IProductsRepository<Products> _repositoryProducts;
        public ProductsService (IProductsRepository<Products> repositoryProducts)
        {
            _repositoryProducts = repositoryProducts;
        }

        public Task<IEnumerable<Products>> GetProducts()
        {
            var products = _repositoryProducts.getAllProducts();

            return products;
        }
        public Task<ShopWebDTO> AddProduct(ShopWebInsertDTO product)
        {
            throw new NotImplementedException();
        }

        public Task<Products> DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }



        public Task<Products> GetProductsById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ShopWebDTO> UpdateProduct(ShopWebInsertDTO product)
        {
            throw new NotImplementedException();
        }
    }
}
