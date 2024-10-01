using E.Commerce.Domain.Entites;
using E.Commerce.Domain.Entites.Categories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Commerce.Infrastracture.ContextDemo
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Ordered> Ordered { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasOne(p => p.ParentCategory)
                  .WithMany(p => p.SubCategories)
                  .HasForeignKey(p => p.ParentCategoryId);

                entity.HasData(
                    new Category { Id = 1, CategoryName = "Electronics", ParentCategoryId = null },
                    new Category { Id = 2, CategoryName = "Fashion", ParentCategoryId = null },
                    new Category { Id = 3, CategoryName = "Beauty & Health", ParentCategoryId = null },
                    new Category { Id = 4, CategoryName = "Appliances", ParentCategoryId = null },
                    new Category { Id = 5, CategoryName = "Supermarket", ParentCategoryId = null },
                    new Category { Id = 6, CategoryName = "Gaming", ParentCategoryId = null }
                    );
            });
        }
    }
}
