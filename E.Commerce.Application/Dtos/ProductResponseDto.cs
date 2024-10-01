using E.Commerce.Domain.Entites.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Commerce.Application.Dtos
{
    public class ProductResponseDto
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Price { get; set; }
        public string Imagepath { get; set; } = null!;
        public int CategoryId { get; set; }
        public int Quantity { get; set; }
    }
}
