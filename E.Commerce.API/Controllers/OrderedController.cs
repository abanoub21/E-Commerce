using E.Commerce.Application.Contract;
using E.Commerce.Application.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E.Commerce.API.Controllers
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderedController : ControllerBase
    {
        private readonly IOrderAppServices services;

        public OrderedController(IOrderAppServices services)
        {
            this.services = services;
        }

        [HttpPost]
        public async Task<OrderedDto> AddOrder(OrderedDto Order)
        {
            return await services.AddOrdered(Order);
        }

        [HttpGet]
        public async Task<List<OrderedDto>> GetAllOrdered()
        {
            return await services.GetAllOrdered();
        }

        [HttpGet]
        public async Task<OrderedDto> GetOrdertbyID(int Id)
        {   
            return await services.GetOrderedbyID(Id);
        }

        [HttpDelete]
        public async Task<OrderedDto> DeleteOrderbyID(int OrderId)
        {
            return await services.DeleteProductbyID(OrderId);
        }

        [HttpPut]
        public async Task<OrderedDto> UpdateOrder(OrderedDto Order)
        {
            return await services.UpdateOrdered(Order);
        }
    }
}
