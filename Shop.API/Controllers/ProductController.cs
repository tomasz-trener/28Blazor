using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Shared;
using Shop.Shared.Models;
using Shop.Shared.Services.ProdcutService;

namespace Shop.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public async Task<ActionResult<ServiceReponse<Product>>> CreateProduct([FromBody] Product product)
        {
            var result = await _productService.CreateProductService(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return NotFound(result);
        }

        [HttpGet]
        public async Task<ActionResult<ServiceReponse<List<Product>>>> GetProducts()
        {
            var result = await _productService.GetProductsAsync();
            if (result.Success)
            {
                return Ok(result);
            }
            return NotFound(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceReponse<Product>>> GetProduct([FromRoute] int id)
        {
            var result = await _productService.GetProductAsync(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return NotFound(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceReponse<bool>>> DeleteProduct([FromRoute] int id)
        {
            var result = await _productService.DeleteProductAsync(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return NotFound(result);
        }

        [HttpPut]
        [Authorize(Roles ="Admin")]
        public async Task<ActionResult<ServiceReponse<Product>>> UpdateProduct([FromBody] Product product)
        {
            var result = await _productService.UpdateProductAsync(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return NotFound(result);
        }

        [HttpGet("search/{text}/{page}/{pageSize}")]
        [HttpGet("search/{page}/{pageSize}")]
        public async Task<ActionResult<ServiceReponse<List<Product>>>> 
            SearchProducts([FromRoute] string? text, [FromRoute] int page=1, [FromRoute] int pageSize=10)
        {
            var result = await _productService.SearchProdutsAsync(text, page, pageSize);
            if (result.Success)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
    }
}


//szkolenia@tomaszles.pl