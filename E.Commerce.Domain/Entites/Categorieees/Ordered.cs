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
    public class Ordered : EntityBase<int>
    {
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }
        public int TotalPrice { get; set; }

        public List<OrderProduct> OrderProducts { get; set; } = null!;
    }
}
