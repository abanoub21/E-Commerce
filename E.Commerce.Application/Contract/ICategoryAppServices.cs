using E.Commerce.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Commerce.Application.Contract
{
    public interface ICategoryAppServices
    {
        Task<CategoryResponseDto> AddCategory(CategoryRequestDto category);
        Task<CategoryResponseDto> DeleteCategoryByID(int id);
        Task<List<CategoryResponseDto>> GetAllCategorys();
        Task<CategoryResponseDto> GetCategoryByID(int id);
        Task<CategoryResponseDto> UpdateCategory(CategoryResponseDto category);
    }
}   
