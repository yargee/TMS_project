using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShop.Data
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductInfo> ProductInfo { get; set; }
        public DbSet<Product> ProductPrice { get; set; }

        public string DbPath { get; set; }

        public ProductDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            DbPath = Path.Combine(Directory.GetCurrentDirectory(), "Products.db");
            options.UseSqlite($"Data Source={DbPath}");
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProductPrice Price { get; set; }
        public ProductInfo ProductInfo {get;set;}

        public Product() { }
        public Product(int id, string name, ProductPrice price, ProductInfo productInfo)
        {
            Id = id;
            Name = name;
            Price = price;
            ProductInfo = productInfo;
        }
    }

    public class ProductInfo
    {
        public int Id { get; set; }
        [ForeignKey("Product")] public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductInfo() { }
        public ProductInfo(int productId, string name, string description)
        {
            ProductId = productId;
            Name = name;
            Description = description;
        }
    }

    public class ProductPrice
    {
        public int Id { get; set; }
        [ForeignKey("Product")] public int ProductId { get; set; }
        public int SupplierPrice { get; set; }
        public int RetailPrice { get; set; }

        public ProductPrice() { }
        public ProductPrice(int id, int productId, int supplierPrice, int retailPrice)
        {
            Id = id;
            ProductId = productId;
            SupplierPrice = supplierPrice;
            RetailPrice = retailPrice;
        }
    }
}
