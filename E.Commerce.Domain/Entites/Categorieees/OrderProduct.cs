using E.Commerce.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace E.Commerce.Domain.Entites.Categories
{
    public class OrderProduct : EntityBase<int>
    {
        public int ProductID { get; set; }

        [ForeignKey("ProductID")]
        public Product Product { get; set; }    
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }

       
        public int OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Ordered Ordered { get; set; }
    }
}
