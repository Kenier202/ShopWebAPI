using ShopWebAPI.DTOs;
using ShopWebAPI.Interfaces;
using ShopWebAPI.Models;

namespace ShopWebAPI.Services
{
    public class ProductsService : IProductsService
    {
        public Task<ShopWebDTO> AddProduct(ShopWebInsertDTO product)
        {
            throw new NotImplementedException();
        }

        public Task<Products> DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Products>> GetProducts()
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
