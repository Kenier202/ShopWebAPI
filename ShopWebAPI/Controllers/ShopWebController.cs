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
        public async Task<ActionResult> getProducts() => await _productsService.GetProducts() is var product && product == null ? NotFound() : Ok(product);

        [HttpGet("{id}")]
        public async Task<ActionResult> getById(int id) =>
            await _productsService.GetProductsById(id) is var product && product == null ? NotFound() : Ok(product);

        [HttpPost]

        public async Task<IActionResult> addProduct(ShopWebInsertDTO productAdd)
        {
            var addProduct = await _productsService.AddProduct(productAdd);

            if (addProduct == null) return BadRequest();

            return CreatedAtAction(nameof(getById), new { id =addProduct.IdProduct }, addProduct);
        }
        //await _productsService.AddProduct(productAdd) is var addProduct && addProduct == null ? NotFound() : Created();

        [HttpDelete("{id}")]

        public async Task<ActionResult> deleteProduct(int id) => await _productsService.DeleteProduct(id)
            is var product && product == null ? NotFound() : Ok(product);

        [HttpPut("{id}")]

        public async Task<ActionResult> updateProduct(int id, ShopWebUpdateDTO product)
        {
            if (id != product.IdProduct) return BadRequest();

            var result = await _productsService.UpdateProduct(product);

            if (result == null) return NotFound();

            return Ok(result);
        }





    }
}
