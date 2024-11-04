using ShopWebAPI.DTOs;
using ShopWebAPI.Models;

namespace ShopWebAPI.Interfaces
{
    public interface IProductsService
    {
        //fetch all products from repository
        Task<IEnumerable<Products>> GetProducts();
        //fetch one product
        Task<ShopWebDTO> GetProductsById(int id);
        //add product
        Task<ShopWebDTO> AddProduct (ShopWebInsertDTO product);
        //update product
        Task<ShopWebUpdateDTO> UpdateProduct(ShopWebUpdateDTO product);
        //delete product
        Task<Products> DeleteProduct (int id);
    }
}
