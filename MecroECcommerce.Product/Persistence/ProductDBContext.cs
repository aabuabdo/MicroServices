using Microsoft.EntityFrameworkCore;

namespace MecroECcommerce.Product.Persistence
{

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }

    }
    public class ProductDBContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductDBContext(DbContextOptions option):base(option) 
        {
            if (!this.Products.Any())
            {
                this.Products.Add(new Product
                {
                    Id = 1,
                    Name = "Product A",
                    Price = 19
                });

                this.Products.Add(new Product
                {
                    Id = 2,
                    Name = "Product B",
                    Price = 19
                });

                this.Products.Add(new Product
                {
                    Id = 3,
                    Name = "Product C",
                    Price = 19
                });

                this.Products.Add(new Product
                {
                    Id = 4,
                    Name = "Product D",
                    Price = 19
                });

                this.Products.Add(new Product
                {
                    Id = 5,
                    Name = "Product E",
                    Price = 19
                });
                this.SaveChanges();
            }
        }
    }
}
