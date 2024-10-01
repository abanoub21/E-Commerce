using E.Commerce.Domain.Entites.Categories;
namespace E.Commerce.Application.Dtos
{
    public class OrderedDto
    {

        public DateTime Date { get; set; }
        public Guid UserId { get; set; }
        public int TotalPrice { get; set; }
    }
}
