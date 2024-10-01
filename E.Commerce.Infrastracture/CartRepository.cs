using E.Commerce.Application.Contract;
using E.Commerce.Domain.Entites.Categories;
using E.Commerce.Infrastracture.ContextDemo;
using Microsoft.EntityFrameworkCore;

namespace E.Commerce.Infrastracture
{
    public class CartRepository : AsyncRepsitory<Cart>, ICartRepository
    {
        private readonly DemoContext db;
        public CartRepository(DemoContext db) : base(db)
        {
            this.db = db;
        }
        public async Task<List<Cart>> GetUserWithCartAsync(Guid userId)
        {
           return await db.Carts.Where(c => c.UserId == userId)
                .Include(d => d.Product)
                .ToListAsync();
        }
        public async Task<bool> DeleteCartsAsync(List<Cart> carts)
        {
            db.Set<Cart>().RemoveRange(carts);
            await db.SaveChangesAsync();
            return true;
        } 
    }
}
