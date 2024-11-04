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


        public async Task<ShopWebDTO> AddProduct(ShopWebInsertDTO product)
        {
            if (product == null) return null;

            var productDb = new Products()
            {
                ProductName = product.ProductName,
                ProductPrice = product.ProductPrice,
                ProductCategory = product.ProductCategory,
                ProductDescription = product.ProductDescription,
                StockQuantity = product.StockQuantity,
                StateProductId = product.IsActive,
                CreatedDate = DateTime.Now,
                ModifiedDate= DateTime.Now,
                ProductCategoryId = product.ProductCategory
            };

            await _repositoryProducts.AddProduct(productDb);

            var productShopWebDTO = new ShopWebDTO()
            { 
                IdProduct = productDb.IdProduct,
                ProductName = productDb.ProductName,
                ProductPrice = productDb.ProductPrice,
                ProductCategory = productDb.ProductCategory,
                ProductDescription = productDb.ProductDescription,
                StockQuantity = productDb.StockQuantity,
                CreatedDate = productDb.CreatedDate,
                IsActive = 1,
                ModifiedDate = productDb.ModifiedDate,
            };
            return productShopWebDTO;

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
