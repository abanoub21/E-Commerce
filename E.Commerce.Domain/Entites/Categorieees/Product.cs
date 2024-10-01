using E.Commerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Commerce.Domain.Entites.Categories
{
    public class Product : EntityBase<int>
    {
        public string Name { get; set; }
        public string Description { get; set; } 
        public int Price { get; set; }
        public string Imagepath { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }  
        public int Quantity { get; set; }
    }
}
