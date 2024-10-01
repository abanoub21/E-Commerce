using E.Commerce.Domain.Common;
using E.Commerce.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Commerce.Domain.Entites.Categories
{
    public class Cart : EntityBase<int>
    {
        public Guid UserId { get; set; }
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; } = null!;
        public int Quantity { get; set; }   
        public int TotalPrice { get; set; }
    }
}