using E.Commerce.Domain.Common;
using E.Commerce.Domain.Entites.Categories;
namespace E.Commerce.Application.Dtos
{
    public class ProductRequestDto 
    {
        public int Id { get; set; } 
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Price { get; set; }
        public string Imagepath { get; set; } = null!;
        public int CategoryId { get; set; }
        public virtual Category? ParentCategory { get; set; }
        public int Quantity { get; set; }
    }
}
