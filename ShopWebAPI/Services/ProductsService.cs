using AutoMapper;
using ShopWebAPI.DTOs;
using ShopWebAPI.Interfaces;
using ShopWebAPI.Models;
using ShopWebAPI.Repositories;

namespace ShopWebAPI.Services
{
    public class ProductsService : IProductsService
    {
        IProductsRepository<Products> _repositoryProducts;
        private IMapper _mapper;
        public ProductsService (IProductsRepository<Products> repositoryProducts, IMapper mapper)
        {
            _repositoryProducts = repositoryProducts;
            _mapper = mapper;
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

            var productDTO = _mapper.Map<ShopWebDTO>(product);

            return productDTO;
        }


        public async Task<ShopWebDTO> AddProduct(ShopWebInsertDTO product)
        {
            if (product == null) return null;

            var productDb = _mapper.Map<Products>(product);

            productDb.CreatedDate = DateTime.UtcNow;
            productDb.ModifiedDate = DateTime.UtcNow;

            await _repositoryProducts.AddProduct(productDb);

            var productShopWebDTO = _mapper.Map<ShopWebDTO>(productDb);

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
            var product = _mapper.Map<Products>(productUpdate);

            await _repositoryProducts.UpdateProduct(product);

            return productUpdate;

        }
    }
}
