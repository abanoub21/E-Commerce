using E.Commerce.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Commerce.Application.Contract
{
    public interface IProductAppServices
    {
        Task<ProductRequestDto> AddProduct(ProductResponseDto product);
        Task<ProductRequestDto> DeleteProductbyID(int productId);
        Task<List<ProductRequestDto>> GetAllProducts();
        Task<ProductRequestDto> GetProductbyID(int id);
        Task<ProductRequestDto> UpdateProduct(int id, ProductResponseDto product);
     
    }
}
