using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MecroECcommerce.Orders.Controllers
{
    [Route("api/")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        [Route("GetAllOrders")]
        public IActionResult GetAllOrders()
        {
            return Ok("AllOrders");
        }
    }
}