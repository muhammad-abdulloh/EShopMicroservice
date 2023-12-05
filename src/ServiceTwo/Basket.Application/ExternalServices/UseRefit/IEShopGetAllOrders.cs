using Basket.Application.ExternalServices.UseRefitModels;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket.Application.ExternalServices.UseRefit
{
    public interface IEShopGetAllOrders
    {
        [Get("/api/Orders/GetAllOrders")]
        Task<List<OrdersWithRefit>> GetUsers();
    }
}
