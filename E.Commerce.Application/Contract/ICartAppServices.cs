using E.Commerce.Application.Dtos;
using E.Commerce.Domain.Entites.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Commerce.Application.Contract
{
    public interface ICartAppServices
    {
        Task<Response<CartResponseDto>> AddProductToCart(CartRequestDto cart);
        Task<CartResponseDto> DeleteFromCartbyID(int ProductId);
        Task<List<CartResponseDto>> GetCartbyUserID(Guid userId);
        Task<CartResponseDto> UpdateCart(CartRequestDto cart);
        Task<OrderedDto> CheckOut(Guid userId);
    }
}
