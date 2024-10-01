using E.Commerce.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Commerce.Application.Contract
{
    public interface IOrderAppServices
    {
        Task<OrderedDto> AddOrdered(OrderedDto Ordered);
        Task<OrderedDto> DeleteProductbyID(int OrderedId);
        Task<List<OrderedDto>> GetAllOrdered();
        Task<OrderedDto> GetOrderedbyID(int Id);
        Task<OrderedDto> UpdateOrdered(OrderedDto Order);
    }
}
