using Basket.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Basket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly BasketDbContext _basketDbContext;

        public BasketController(BasketDbContext basketDbContext)
        {
            _basketDbContext = basketDbContext;
        }

        [HttpGet]
        public async ValueTask<ActionResult> GetAllOrders()
        {
            return Ok(_basketDbContext.Baskets);
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateOrder(BasketModel order)
        {
            await _basketDbContext.Baskets.AddAsync(order);
            await _basketDbContext.SaveChangesAsync();

            return Ok(order);
        }
    }
}
