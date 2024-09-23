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

    }
}
