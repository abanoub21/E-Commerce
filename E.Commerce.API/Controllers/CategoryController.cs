using E.Commerce.Application.Contract;
using E.Commerce.Application.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E.Commerce.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryAppServices services;

        public CategoryController(ICategoryAppServices services)
        {
            this.services = services;
        }
        [HttpPost]
        public async Task<CategoryResponseDto> AddCategory(CategoryRequestDto category)
        {
            return await services.AddCategory(category);
        }
        [HttpDelete]
        public async Task<CategoryResponseDto> DeleteCategoryByID(int id)
        {
            return await services.DeleteCategoryByID(id);
        }
        [HttpGet]
        public async Task<List<CategoryResponseDto>> GetAllCategorys()
        {
            return await services.GetAllCategorys();
        }
        [HttpGet]
        public async Task<CategoryResponseDto> GetCategoryByID(int id)
        {
            return await services.GetCategoryByID(id);
        }
        [HttpPut]
        public async Task<CategoryResponseDto> UpdateCategory(CategoryResponseDto category)
        {
            return await services.UpdateCategory(category);
        }
    }
}
