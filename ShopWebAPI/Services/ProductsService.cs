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

        public async Task<IEnumerable<Products>> GetProducts()
        {
            var products = await _repositoryProducts.getAllProducts();
            if (products == null) return null ;

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
                ProductCategory = product.ProductCategoryId,
                ProductDescription = product.ProductDescription,
                StockQuantity = product.StockQuantity,
                StateProduct = product.StateProductId,
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
                ProductDescription = product.ProductDescription,
                StockQuantity = product.StockQuantity,
                StateProductId = product.StateProductId,
                CreatedDate = DateTime.Now,
                ModifiedDate= DateTime.Now,
                ProductCategoryId = Convert.ToInt32(product.ProductCategoryId)
            };

            await _repositoryProducts.AddProduct(productDb);

            var productShopWebDTO = new ShopWebDTO()
            { 
                IdProduct = productDb.IdProduct,
                ProductName = productDb.ProductName,
                ProductPrice = productDb.ProductPrice,
                ProductCategory = productDb.ProductCategoryId,
                ProductDescription = productDb.ProductDescription,
                StockQuantity = productDb.StockQuantity,
                CreatedDate = productDb.CreatedDate,
                StateProduct = productDb.StateProductId,
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
