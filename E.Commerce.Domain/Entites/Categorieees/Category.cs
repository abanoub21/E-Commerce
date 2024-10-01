using E.Commerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Commerce.Domain.Entites.Categories
{
    public class Category : EntityBase<int>
    {
        public string CategoryName { get; set; } = null!;
        public int? ParentCategoryId { get; set; }
        public virtual Category? ParentCategory { get; set; }
        public virtual List<Category>? SubCategories { get; set;}
    }
}
