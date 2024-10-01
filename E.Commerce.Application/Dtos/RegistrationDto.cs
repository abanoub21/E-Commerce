namespace E.Commerce.Application.Dtos
{
    public class RegistrationDto
    {
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string MobileNo { get; set; } = null!;
    }
}
