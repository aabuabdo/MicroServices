using MecroECcommerce.Product.Models;
using MecroECcommerce.Product.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MecroECcommerce.Product.Controllers
{
    [Route("api/")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet]
        [Route("Products")]
      public IActionResult GetAllProduct()
        {
            var result = _productService.GetAllProducts();
            return Ok(result); 
        }
        [HttpGet("GetProductById")]
        public ActionResult<ProductModel> GetProductById(int id)
        {
            var product = _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound(); 
            }
            return Ok(product); 
        }
    }
}
