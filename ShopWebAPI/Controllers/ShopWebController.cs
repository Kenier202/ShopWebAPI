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

        [HttpGet("{id}")]
        public async Task<ActionResult> getById(int id ) => 
            await _productsService.GetProductsById(id) is var product && product == null ? NotFound() : Ok(product);

        [HttpPost]

        public async Task<ActionResult> addProduct(ShopWebInsertDTO product) =>
            await _productsService.AddProduct(product) is var addProduct && addProduct == null ? NotFound() : Ok(product);



    }
}
