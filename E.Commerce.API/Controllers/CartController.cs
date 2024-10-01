using E.Commerce.Application.Contract;
using E.Commerce.Application.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E.Commerce.API.Controllers
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartAppServices services;
        public CartController(ICartAppServices services)
        {
            this.services = services;
        }

        [HttpPost]
        public async Task<Response<CartResponseDto>> AddToCart(CartRequestDto product)
        {
            return await services.AddProductToCart(product);
        }

        [HttpGet]
        public async Task<List<CartResponseDto>> GetCartbyUserID(Guid userId)
        {
            return await services.GetCartbyUserID(userId);
        }

        [HttpDelete]
        public async Task<CartResponseDto> DeleteFromCartbyID(int productId)
        {
            return await services.DeleteFromCartbyID(productId);
        }

        [HttpPut]
        public async Task<CartResponseDto> UpdateCart(CartRequestDto product)
        {
            return await services.UpdateCart(product);
        }

        [HttpPost]
        public async Task<OrderedDto> CheckOut([FromBody] Guid userId)
        {
            return await services.CheckOut(userId);
        }
    }
}
