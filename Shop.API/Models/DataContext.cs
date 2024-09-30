using Microsoft.EntityFrameworkCore;
using Shop.DataSeeder;
using Shop.Shared.Auth;
using Shop.Shared.Models;

namespace Shop.API.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>().HasData(
            //    new Product
            //    {
            //        Id = 1,
            //        Name = "Product 1",
            //        Price = 100,
            //        Description = "Description 1",
            //        Barcode = "123456789",
            //        CreatedDate = System.DateTime.Now
            //    },
            //    new Product
            //    {
            //        Id = 2,
            //        Name = "Product 2",
            //        Price = 200,
            //        Description = "Description 2",
            //        Barcode = "987654321",
            //        CreatedDate = System.DateTime.Now
            //    }
            //);
            modelBuilder.Entity<Product>().HasData(ProductsDataSeeder.GenerateProductsData());

        }

    }
}
