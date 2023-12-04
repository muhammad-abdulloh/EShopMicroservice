using EShop.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShop.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly EShopDbContext _eshopDbContext;

        public OrdersController(EShopDbContext eshopDbContext)
        {
            _eshopDbContext = eshopDbContext;
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public async ValueTask<ActionResult> GetAllOrders()
        {
            return Ok(_eshopDbContext.Orders);
        }

        [HttpPost]
        //[Authorize(Roles = "Administrator")]
        public async ValueTask<IActionResult> CreateOrder(Order order)
        {
            await _eshopDbContext.Orders.AddAsync(order);
            await _eshopDbContext.SaveChangesAsync();

            return Ok(order);
        }

        [HttpGet]
        //[Authorize(Roles = "Administrator,User")]
        public async ValueTask<ActionResult> GetAllOrdersForUsers()
        {
            return Ok(_eshopDbContext.Orders);
        }
    }
}
