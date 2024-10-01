using E.Commerce.Domain.Common;
namespace E.Commerce.Application.Dtos
{
    public class CategoryResponseDto 
    {
        public int Id { get; set; } 
        public string CategoryName { get; set; } = null!;
        public int? ParentCategoryId { get; set; }
    }
}
