using ShopWebAPI.DTOs;
using ShopWebAPI.Models;

namespace ShopWebAPI.Interfaces
{
    public interface IProducts
    {
        //get all products from table products
        Task<IEnumerable<Products>> GetAllProducts();
        //get product by id
        Task<Products> GetProductById (int id);
        //add new product
        Task<ShopWebInsertDTO> AddProduct (ShopWebInsertDTO shopWebInsertDTO);
        //update a product
        Task<ShopWebUpdateDTO> UpdateProduct (ShopWebUpdateDTO shopWebUpdateDTO);
        //delete a product 
        Task<Products> DeleteProduct (int id);
    }
}
