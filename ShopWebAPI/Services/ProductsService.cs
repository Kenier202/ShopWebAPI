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

        public async Task<ShopWebDTO> GetProductsById(int id)
        {
            var product = await _repositoryProducts.GetProductById(id);

            if (product == null) return null;

            var productDTO = new ShopWebDTO() 
            {
                IdProduct = product.IdProduct,
                ProductName = product.ProductName,
                ProductPrice = product.ProductPrice,
                ProductCategory = product.ProductCategory,
                ProductDescription = product.ProductDescription,
                StockQuantity = product.StockQuantity,
                IsActive = product.StateProductId,
                CreatedDate = product.CreatedDate,
                ModifiedDate = product.ModifiedDate,
            };

            return productDTO;
        }


        public Task<ShopWebDTO> AddProduct(ShopWebInsertDTO product)
        {
            throw new NotImplementedException();
        }

        public Task<Products> DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ShopWebDTO> UpdateProduct(ShopWebInsertDTO product)
        {
            throw new NotImplementedException();
        }
    }
}
