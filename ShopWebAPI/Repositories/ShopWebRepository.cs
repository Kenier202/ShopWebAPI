using ShopWebAPI.DTOs;

namespace ShopWebAPI.Repositories
{
    public interface ShopWebRepository<TEntity>
    {
        public Task<IEnumerable<TEntity>> getAllProducts();
        public Task<TEntity> GetProductById();
        public Task AddProduct (TEntity product);
        public Task UpdateProduct (TEntity product);
        public Task DeleteProduct (TEntity product);
        Task save();

    }
}
