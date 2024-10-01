namespace E.Commerce.Application.Dtos
{
    public class CartResponseDto
    {
        public Guid UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
    }
}
