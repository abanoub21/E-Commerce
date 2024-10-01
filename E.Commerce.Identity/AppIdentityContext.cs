using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E.Commerce.Identity
{
    public class AppIdentityContext : IdentityDbContext
    {
        public AppIdentityContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Name = "Admin", NormalizedName = "Admin", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new IdentityRole() { Name = "User", NormalizedName = "User", ConcurrencyStamp = Guid.NewGuid().ToString() }
                );
        }
    }
}