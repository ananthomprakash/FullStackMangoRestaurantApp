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
                ImageUrl = "https://restaurantproject1.s3.us-east-1.amazonaws.com/res2.jpg?response-content-disposition=inline&X-Amz-Security-Token=IQoJb3JpZ2luX2VjENr%2F%2F%2F%2F%2F%2F%2F%2F%2F%2FwEaCmFwLXNvdXRoLTEiRzBFAiB4OhYOIqoV8zlRtndyEpb95A1dKYQqhpKD%2BFAVcU37ZQIhAMvohXfFVgMq7hAZQlNCvlgv1zl5r6mAIhmEFTYE9ZFhKoQDCPP%2F%2F%2F%2F%2F%2F%2F%2F%2F%2FwEQARoMNTg4NTU4MDYzOTQ0Igy9RCpZ4S%2FTb768cEwq2AITKmJTX4AhZ7qTFna%2Fffif74wPrUWrpElaVqXbSICC%2BWwZKGZzD5BJZk2pSNiUSjE%2BwO5966uidPxqsLfsvCU0lbJldEDDldMTEA7bzjJYWwnDmZCmbfQ0Ly8qBZYnToFC75VIeAlfviFNVJhttJwqhj%2BdkewCmPMw8qYNsrX7Eu81lyrS32iXeRvMh3mmhBF4veGepeVl4%2BVbVQjOXoUarl67k3%2BNmyXK6SiQvUBxZ%2FkrqKiMxJkWid%2F7IC01TpZa05fQ5U3XPdIr3NHadbS5yROavBfRHYLEwQjk30bm%2FewW4GhiJod4ewt9PMPHWsXq7YbKLHiEZuiFhESOcuZyV8a8WbKRUDYw2nDnfcm9sNxRvIpG4PNaeyLnm2ajFLTQ7YVix7Sj%2Fy%2F4I8odAQJJ%2BzTSSVPdbNohODIVqhjB2pSjstNqTtfl3FtSfMV6q1rgP6aNHHGldDDgge2VBjqzAub4ktnZphyJnXhB0dJPU7H7LjX56LT8azxNnWRZ3SWaH85BlbMoWyUFIRRPGykXNcmeMzRy8HDNbEm%2Fd64b1qHaZINuNpS5DBcu7NSPE2jyPUeyuXXOiAhj7vEYnNVdpYCVncgObcU3teYjN5Ojv4HDwWwUGZ2Ftqe7kriU%2FLP8Cq9XYQQHmocp7%2Byvpu1BoLY38hYERpTaAq7Eoua%2BbL4jz3ywv%2Fyb17GgnGAjM8futAQCsWwll9c9AbruxUSHVHdonsKECe9fn2xaDx02v87b%2FYLkIQ7Cupitp1NkPM1Qo9ZWlZMWupRAt%2FEcUtfvyyyB6wH8hsmhfLrD99S7e7IhTVxfswDUAuTPqekufmbPkjU1WvpjVTJL5qG7hBWDzHDKezfz1DyJT3QEaVHSNjFvUH8%3D&X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Date=20220628T192010Z&X-Amz-SignedHeaders=host&X-Amz-Expires=3600&X-Amz-Credential=ASIAYSCGLLFEINCZRHHW%2F20220628%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Signature=5f875f2e7ef8788cb1c92bcc5d9548fc06eb994f142e88943e3660da8c6e0caf",
                CategoryName = "Appatizer"
            });
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 2,
                    Name = "Paneer Tikka",
                    Price=12,
                    Description ="loreum imposium 2",
                    ImageUrl= "https://restaurantproject1.s3.us-east-1.amazonaws.com/res3.jpg?response-content-disposition=inline&X-Amz-Security-Token=IQoJb3JpZ2luX2VjENr%2F%2F%2F%2F%2F%2F%2F%2F%2F%2FwEaCmFwLXNvdXRoLTEiRzBFAiB4OhYOIqoV8zlRtndyEpb95A1dKYQqhpKD%2BFAVcU37ZQIhAMvohXfFVgMq7hAZQlNCvlgv1zl5r6mAIhmEFTYE9ZFhKoQDCPP%2F%2F%2F%2F%2F%2F%2F%2F%2F%2FwEQARoMNTg4NTU4MDYzOTQ0Igy9RCpZ4S%2FTb768cEwq2AITKmJTX4AhZ7qTFna%2Fffif74wPrUWrpElaVqXbSICC%2BWwZKGZzD5BJZk2pSNiUSjE%2BwO5966uidPxqsLfsvCU0lbJldEDDldMTEA7bzjJYWwnDmZCmbfQ0Ly8qBZYnToFC75VIeAlfviFNVJhttJwqhj%2BdkewCmPMw8qYNsrX7Eu81lyrS32iXeRvMh3mmhBF4veGepeVl4%2BVbVQjOXoUarl67k3%2BNmyXK6SiQvUBxZ%2FkrqKiMxJkWid%2F7IC01TpZa05fQ5U3XPdIr3NHadbS5yROavBfRHYLEwQjk30bm%2FewW4GhiJod4ewt9PMPHWsXq7YbKLHiEZuiFhESOcuZyV8a8WbKRUDYw2nDnfcm9sNxRvIpG4PNaeyLnm2ajFLTQ7YVix7Sj%2Fy%2F4I8odAQJJ%2BzTSSVPdbNohODIVqhjB2pSjstNqTtfl3FtSfMV6q1rgP6aNHHGldDDgge2VBjqzAub4ktnZphyJnXhB0dJPU7H7LjX56LT8azxNnWRZ3SWaH85BlbMoWyUFIRRPGykXNcmeMzRy8HDNbEm%2Fd64b1qHaZINuNpS5DBcu7NSPE2jyPUeyuXXOiAhj7vEYnNVdpYCVncgObcU3teYjN5Ojv4HDwWwUGZ2Ftqe7kriU%2FLP8Cq9XYQQHmocp7%2Byvpu1BoLY38hYERpTaAq7Eoua%2BbL4jz3ywv%2Fyb17GgnGAjM8futAQCsWwll9c9AbruxUSHVHdonsKECe9fn2xaDx02v87b%2FYLkIQ7Cupitp1NkPM1Qo9ZWlZMWupRAt%2FEcUtfvyyyB6wH8hsmhfLrD99S7e7IhTVxfswDUAuTPqekufmbPkjU1WvpjVTJL5qG7hBWDzHDKezfz1DyJT3QEaVHSNjFvUH8%3D&X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Date=20220628T192057Z&X-Amz-SignedHeaders=host&X-Amz-Expires=3600&X-Amz-Credential=ASIAYSCGLLFEINCZRHHW%2F20220628%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Signature=012a21f57dd56d7926e85c1d928e36d5341abcb04f9d5c5e1009fd5aedeb1a3a",
                    CategoryName="Appatizer"
                }) ;
        }

    }
}
