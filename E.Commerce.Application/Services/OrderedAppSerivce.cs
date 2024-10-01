using AutoMapper;
using E.Commerce.Application.Contract;
using E.Commerce.Application.Dtos;
using E.Commerce.Domain.Entites.Categories;

namespace E.Commerce.Application.Services
{
    public class OrderedAppSerivce : IOrderAppServices
    {
        private readonly IAsyncRepository<Ordered> rep;
        private readonly IMapper mapper;

        public OrderedAppSerivce(IAsyncRepository<Ordered> rep , IMapper mapper)
        {
            this.rep = rep;
            this.mapper = mapper;
        }

        public async Task<OrderedDto> AddOrdered(OrderedDto Ordered)
        {
            var orderDb = mapper.Map<Ordered>(Ordered);
            var data = await rep.AddAsync(orderDb); 
            var result = mapper.Map<OrderedDto>(data);  
            return result;
        }

        public async Task<OrderedDto> DeleteProductbyID(int OrderedId)
        {
            var data = await rep.DeleteByIdAsync(OrderedId);
            var result = mapper.Map<OrderedDto>(data);
            return result;
        }

        public async Task<List<OrderedDto>> GetAllOrdered()
        {
             var data = await rep.GetAllAsync();
            var result = mapper.Map<List<OrderedDto>>(data);
            return result;
        }

        public async Task<OrderedDto> GetOrderedbyID(int Id)
        {
            var data = await rep.GetByIDAsync(Id);
            var result = mapper.Map<OrderedDto>(data);
            return result;
        }

        public async Task<OrderedDto> UpdateOrdered(OrderedDto Order)
        {
            var orderDb = mapper.Map<Ordered>(Order);
            var data = await rep.UpdateAsync(orderDb);
            var result = mapper.Map<OrderedDto>(data);
            return result;
        }
    }
}
