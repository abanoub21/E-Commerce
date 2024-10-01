using AutoMapper;
using E.Commerce.Application.Contract;
using E.Commerce.Application.Dtos;
using E.Commerce.Domain.Entites.Categories;

namespace E.Commerce.Application.Services
{
    public class ProductAppService : IProductAppServices
    {
        private readonly IAsyncRepository<Product> rep;
        private readonly IMapper mapper;

        public ProductAppService(IAsyncRepository<Product> rep, IMapper mapper) 
        {
            this.rep = rep;
            this.mapper = mapper;
        }
       
        public async Task<ProductRequestDto> AddProduct(ProductResponseDto product)
        {
            var getter = mapper.Map<Product>(product);
            var data = await rep.AddAsync(getter);
            return mapper.Map<ProductRequestDto>(data);
        }

        public async Task<ProductRequestDto> DeleteProductbyID(int productId)
        {
            var data = await rep.DeleteByIdAsync(productId);
           return mapper.Map<ProductRequestDto>(data);       
        }

        public async Task<List<ProductRequestDto>> GetAllProducts()
        {
           var data = await rep.GetAllAsync();
           return mapper.Map<List<ProductRequestDto>>(data);
        }

        public async Task<ProductRequestDto> GetProductbyID(int id)
        {
            var data = await rep.GetByIDAsync(id);
            return mapper.Map<ProductRequestDto>(data);  
        }

        public async Task<ProductRequestDto> UpdateProduct(int id ,ProductResponseDto product)
        {
            var old = mapper.Map<Product>(product);
            old.Id = id;
            var data = await rep.UpdateAsync(old);
            return mapper.Map<ProductRequestDto>(data);  
        }
    }
}
