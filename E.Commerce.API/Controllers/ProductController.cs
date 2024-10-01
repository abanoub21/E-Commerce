using E.Commerce.Application.Contract;
using E.Commerce.Application.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E.Commerce.API.Controllers
{
   // [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductAppServices services;
        public ProductController(IProductAppServices services)
        {
            this.services = services;
        }

        [HttpPost]
        public async Task<ProductRequestDto> AddProduct(ProductResponseDto product)
        {
            return await services.AddProduct(product);
        }

        [HttpGet]
        public async Task<List<ProductRequestDto>> GetAllProducts()
        {
            return await services.GetAllProducts();
        }

        [HttpGet]
        public async Task<ProductRequestDto> GetProductbyID(int Id)
        {
            return await services.GetProductbyID(Id);
        }

        [HttpDelete]
        public async Task<ProductRequestDto> DeleteProductbyID(int productId)
        {
            return await services.DeleteProductbyID(productId);
        }

        [HttpPut]
        public async Task<ProductRequestDto> UpdateProduct(int id, [FromBody] ProductResponseDto product)
        {
            return await services.UpdateProduct(id,product);
        }
    }
}
