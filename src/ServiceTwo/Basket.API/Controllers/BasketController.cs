using Basket.API.Models;
using Basket.Application.ExternalServices.UseRefit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Refit;

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
            /// domendan olish
            //var userAPI = RestService.For<IEShopGetAllOrders>("https://jsonplaceholder.typicode.com");
            // dockerdan olish
            var userAPI = RestService.For<IEShopGetAllOrders>("http://eshop.api:80");
            //api gatewaydan olish
            //var userAPI = RestService.For<IEShopGetAllOrders>("http://host.docker.internal:7180");
            var users = await userAPI.GetUsers();
            return Ok(users);
            //return Ok(_basketDbContext.Baskets);
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
