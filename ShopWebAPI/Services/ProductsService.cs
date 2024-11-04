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

            var productos = products.Select(p => new Products
            {
                IdProduct = p.IdProduct,
                ProductName = p.ProductName,
                ProductPrice = p.ProductPrice,
                ProductCategoryId = p.ProductCategoryId,
                ProductDescription = p.ProductDescription,
                StockQuantity = p.StockQuantity,
                StateProductId = p.StateProductId,
                CreatedDate = p.CreatedDate,
                ModifiedDate = p.ModifiedDate
            });

            return productos;
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

        public async Task<Products> DeleteProduct(int id)
        {
            var product = await _repositoryProducts.GetProductById(id);


            await _repositoryProducts.DeleteProduct(product);

            return product;
        }

        public async Task<ShopWebUpdateDTO> UpdateProduct(ShopWebUpdateDTO productUpdate)
        {
            var product = new Products()
            {
                IdProduct = productUpdate.IdProduct,
                ProductName = productUpdate.ProductName,
                ProductPrice = productUpdate.ProductPrice,
                ProductCategoryId = productUpdate.ProductCategoryid,
                ProductDescription = productUpdate.ProductDescription,
                StockQuantity = productUpdate.StockQuantity,
                ModifiedDate = DateTime.Now,
                StateProductId = productUpdate.StateProductid
            };

            await _repositoryProducts.UpdateProduct(product);

            return productUpdate;

        }
    }
}
