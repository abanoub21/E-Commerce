using E.Commerce.Domain.Entites.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Commerce.Application.Contract
{
    public interface ICartRepository : IAsyncRepository<Cart>
    {
       Task<List<Cart>> GetUserWithCartAsync(Guid userId);
        Task<bool> DeleteCartsAsync(List<Cart> carts);
    }
}
