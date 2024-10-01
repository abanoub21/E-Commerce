namespace E.Commerce.Application.Dtos
{
    public class CustomToken
    {
        public string Token { get; set; } = null!;
        public DateTime Expiration { get; set; }
    }
}
