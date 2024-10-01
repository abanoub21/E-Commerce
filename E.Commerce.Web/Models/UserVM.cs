namespace E.Commerce.Web.Models
{
    public class UserVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public int Password { get; set; }
        public int Phone { get; set; }
    }
}
