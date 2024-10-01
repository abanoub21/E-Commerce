using E.Commerce.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;
namespace E.Commerce.Application.Dtos
{
    public class OrderProductDto
    {
        
        public int Id { get; set; }
        public int ProductID { get; set; }
        public int Qantity { get; set; }
        public int TotalPraice { get; set; }
        public int OrderId { get; set; }
    }
}