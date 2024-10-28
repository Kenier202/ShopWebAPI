﻿using ShopWebAPI.DTOs;
using ShopWebAPI.Models;

namespace ShopWebAPI.Interfaces
{
    public interface IProductsService
    {
        //fetch all products from repository
        Task<IEnumerable<Products>> GetProducts();
        //fetch one product
        Task<Products> GetProductsById(int id);
        //add product
        Task<ShopWebDTO> AddProduct (ShopWebInsertDTO product);
        //update product
        Task<ShopWebDTO> UpdateProduct(ShopWebInsertDTO product);
        //delete product
        Task<Products> DeleteProduct (int id);
    }
}
