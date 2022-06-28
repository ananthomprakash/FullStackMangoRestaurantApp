using Mango.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Samosa",
                Price = 15,
                Description = "loreum inposium",
                ImageUrl = "",
                CategoryName = "Appatizer"
            });
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 2,
                    Name = "Paneer Tikka",
                    Price=12,
                    Description ="loreum imposium 2",
                    ImageUrl="",
                    CategoryName="Appatizer"
                }) ;
        }

    }
}
