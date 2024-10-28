using ShopWebAPI.DTOs;

namespace ShopWebAPI.Repositories
{
    public interface IProductsRepository<TEntity>
    {
        public Task<IEnumerable<TEntity>> getAllProducts();
        public Task<TEntity> GetProductById(int IdProduct);
        public Task AddProduct (TEntity product);
        public Task UpdateProduct (TEntity product);
        public Task DeleteProduct (TEntity product);
        Task save();

    }
}
