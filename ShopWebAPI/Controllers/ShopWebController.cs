using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopWebAPI.DTOs;
using ShopWebAPI.Interfaces;
using ShopWebAPI.Models;

namespace ShopWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopWebController : ControllerBase
    {
        private IProductsService _productsService;
        public ShopWebController(IProductsService productsService) 
        {
            _productsService = productsService;
        }

        [HttpGet]
        public async Task<IEnumerable<Products>> getProducts() => await _productsService.GetProducts();

   

    }
}
