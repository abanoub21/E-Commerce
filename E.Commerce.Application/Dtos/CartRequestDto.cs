namespace E.Commerce.Application.Dtos
{
    public class CartRequestDto
    {
        public Guid UserId { get; set; } 
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}