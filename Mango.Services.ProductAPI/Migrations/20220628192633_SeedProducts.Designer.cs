﻿// <auto-generated />
using Mango.Services.ProductAPI.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Mango.Services.ProductAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220628192633_SeedProducts")]
    partial class SeedProducts
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Mango.Services.ProductAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryName = "Appatizer",
                            Description = "loreum inposium",
                            ImageUrl = "https://restaurantproject1.s3.us-east-1.amazonaws.com/res2.jpg?response-content-disposition=inline&X-Amz-Security-Token=IQoJb3JpZ2luX2VjENr%2F%2F%2F%2F%2F%2F%2F%2F%2F%2FwEaCmFwLXNvdXRoLTEiRzBFAiB4OhYOIqoV8zlRtndyEpb95A1dKYQqhpKD%2BFAVcU37ZQIhAMvohXfFVgMq7hAZQlNCvlgv1zl5r6mAIhmEFTYE9ZFhKoQDCPP%2F%2F%2F%2F%2F%2F%2F%2F%2F%2FwEQARoMNTg4NTU4MDYzOTQ0Igy9RCpZ4S%2FTb768cEwq2AITKmJTX4AhZ7qTFna%2Fffif74wPrUWrpElaVqXbSICC%2BWwZKGZzD5BJZk2pSNiUSjE%2BwO5966uidPxqsLfsvCU0lbJldEDDldMTEA7bzjJYWwnDmZCmbfQ0Ly8qBZYnToFC75VIeAlfviFNVJhttJwqhj%2BdkewCmPMw8qYNsrX7Eu81lyrS32iXeRvMh3mmhBF4veGepeVl4%2BVbVQjOXoUarl67k3%2BNmyXK6SiQvUBxZ%2FkrqKiMxJkWid%2F7IC01TpZa05fQ5U3XPdIr3NHadbS5yROavBfRHYLEwQjk30bm%2FewW4GhiJod4ewt9PMPHWsXq7YbKLHiEZuiFhESOcuZyV8a8WbKRUDYw2nDnfcm9sNxRvIpG4PNaeyLnm2ajFLTQ7YVix7Sj%2Fy%2F4I8odAQJJ%2BzTSSVPdbNohODIVqhjB2pSjstNqTtfl3FtSfMV6q1rgP6aNHHGldDDgge2VBjqzAub4ktnZphyJnXhB0dJPU7H7LjX56LT8azxNnWRZ3SWaH85BlbMoWyUFIRRPGykXNcmeMzRy8HDNbEm%2Fd64b1qHaZINuNpS5DBcu7NSPE2jyPUeyuXXOiAhj7vEYnNVdpYCVncgObcU3teYjN5Ojv4HDwWwUGZ2Ftqe7kriU%2FLP8Cq9XYQQHmocp7%2Byvpu1BoLY38hYERpTaAq7Eoua%2BbL4jz3ywv%2Fyb17GgnGAjM8futAQCsWwll9c9AbruxUSHVHdonsKECe9fn2xaDx02v87b%2FYLkIQ7Cupitp1NkPM1Qo9ZWlZMWupRAt%2FEcUtfvyyyB6wH8hsmhfLrD99S7e7IhTVxfswDUAuTPqekufmbPkjU1WvpjVTJL5qG7hBWDzHDKezfz1DyJT3QEaVHSNjFvUH8%3D&X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Date=20220628T192010Z&X-Amz-SignedHeaders=host&X-Amz-Expires=3600&X-Amz-Credential=ASIAYSCGLLFEINCZRHHW%2F20220628%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Signature=5f875f2e7ef8788cb1c92bcc5d9548fc06eb994f142e88943e3660da8c6e0caf",
                            Name = "Samosa",
                            Price = 15.0
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryName = "Appatizer",
                            Description = "loreum imposium 2",
                            ImageUrl = "https://restaurantproject1.s3.us-east-1.amazonaws.com/res3.jpg?response-content-disposition=inline&X-Amz-Security-Token=IQoJb3JpZ2luX2VjENr%2F%2F%2F%2F%2F%2F%2F%2F%2F%2FwEaCmFwLXNvdXRoLTEiRzBFAiB4OhYOIqoV8zlRtndyEpb95A1dKYQqhpKD%2BFAVcU37ZQIhAMvohXfFVgMq7hAZQlNCvlgv1zl5r6mAIhmEFTYE9ZFhKoQDCPP%2F%2F%2F%2F%2F%2F%2F%2F%2F%2FwEQARoMNTg4NTU4MDYzOTQ0Igy9RCpZ4S%2FTb768cEwq2AITKmJTX4AhZ7qTFna%2Fffif74wPrUWrpElaVqXbSICC%2BWwZKGZzD5BJZk2pSNiUSjE%2BwO5966uidPxqsLfsvCU0lbJldEDDldMTEA7bzjJYWwnDmZCmbfQ0Ly8qBZYnToFC75VIeAlfviFNVJhttJwqhj%2BdkewCmPMw8qYNsrX7Eu81lyrS32iXeRvMh3mmhBF4veGepeVl4%2BVbVQjOXoUarl67k3%2BNmyXK6SiQvUBxZ%2FkrqKiMxJkWid%2F7IC01TpZa05fQ5U3XPdIr3NHadbS5yROavBfRHYLEwQjk30bm%2FewW4GhiJod4ewt9PMPHWsXq7YbKLHiEZuiFhESOcuZyV8a8WbKRUDYw2nDnfcm9sNxRvIpG4PNaeyLnm2ajFLTQ7YVix7Sj%2Fy%2F4I8odAQJJ%2BzTSSVPdbNohODIVqhjB2pSjstNqTtfl3FtSfMV6q1rgP6aNHHGldDDgge2VBjqzAub4ktnZphyJnXhB0dJPU7H7LjX56LT8azxNnWRZ3SWaH85BlbMoWyUFIRRPGykXNcmeMzRy8HDNbEm%2Fd64b1qHaZINuNpS5DBcu7NSPE2jyPUeyuXXOiAhj7vEYnNVdpYCVncgObcU3teYjN5Ojv4HDwWwUGZ2Ftqe7kriU%2FLP8Cq9XYQQHmocp7%2Byvpu1BoLY38hYERpTaAq7Eoua%2BbL4jz3ywv%2Fyb17GgnGAjM8futAQCsWwll9c9AbruxUSHVHdonsKECe9fn2xaDx02v87b%2FYLkIQ7Cupitp1NkPM1Qo9ZWlZMWupRAt%2FEcUtfvyyyB6wH8hsmhfLrD99S7e7IhTVxfswDUAuTPqekufmbPkjU1WvpjVTJL5qG7hBWDzHDKezfz1DyJT3QEaVHSNjFvUH8%3D&X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Date=20220628T192057Z&X-Amz-SignedHeaders=host&X-Amz-Expires=3600&X-Amz-Credential=ASIAYSCGLLFEINCZRHHW%2F20220628%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Signature=012a21f57dd56d7926e85c1d928e36d5341abcb04f9d5c5e1009fd5aedeb1a3a",
                            Name = "Paneer Tikka",
                            Price = 12.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
