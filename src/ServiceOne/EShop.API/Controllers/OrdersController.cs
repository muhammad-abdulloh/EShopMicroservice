using EShop.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly EShopDbContext _eshopDbContext;

        public OrdersController(EShopDbContext eshopDbContext)
        {
            _eshopDbContext = eshopDbContext;
        }

        [HttpGet]
        public async ValueTask<ActionResult> GetAllOrders()
        {
            return Ok(_eshopDbContext.Orders);
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateOrder(Order order)
        {
            await _eshopDbContext.Orders.AddAsync(order);
            await _eshopDbContext.SaveChangesAsync();

            return Ok(order);
        }
    }
}
