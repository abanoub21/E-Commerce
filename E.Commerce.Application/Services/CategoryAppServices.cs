using AutoMapper;
using E.Commerce.Application.Contract;
using E.Commerce.Application.Dtos;
using E.Commerce.Domain.Entites.Categories;

namespace E.Commerce.Application.Services
{
    public class CategoryAppServices : ICategoryAppServices
    {
        private readonly IAsyncRepository<Category> repository;
        private readonly IMapper mapper;

        public CategoryAppServices(IAsyncRepository<Category> repository , IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<CategoryResponseDto> AddCategory(CategoryRequestDto category)
        {
            var getter = mapper.Map<Category>(category);
            var data = await repository.AddAsync(getter);
            return mapper.Map<CategoryResponseDto>(data);

        }

        public async Task<CategoryResponseDto> DeleteCategoryByID(int id)
        {
            var data = await repository.DeleteByIdAsync(id);
            return mapper.Map<CategoryResponseDto>(data);
        }

        public async Task<List<CategoryResponseDto>> GetAllCategorys()
        {
            var data = await repository.GetAllAsync();
           return mapper.Map<List<CategoryResponseDto>>(data);
        }

        public async Task<CategoryResponseDto> GetCategoryByID(int id)
        {
            var data = await repository.GetByIDAsync(id);
            return mapper.Map<CategoryResponseDto>(data);
        }

        public async Task<CategoryResponseDto> UpdateCategory(CategoryResponseDto category)
        {
            var old = mapper.Map<Category>(category);
            var data = await repository.UpdateAsync(old);
            return mapper.Map<CategoryResponseDto>(data);
        }
    }
}
