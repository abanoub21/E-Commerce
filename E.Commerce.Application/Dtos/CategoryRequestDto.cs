using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Commerce.Application.Dtos
{
    public class CategoryRequestDto
    {
        public string CategoryName { get; set; } = null!;
        public int? ParentCategoryId { get; set; }
    }
}
