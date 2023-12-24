using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureWebApi.Data
{
    public class FurnitureDbContext : DbContext
    {
        public DbSet<FurnitureCollection> Collections { get; set; }
        public DbSet<FurnitureElement> Elements { get; set; }
        public DbSet<ElementPrice> ElementsPrice { get; set; }
        public string DbPath { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            DbPath = Path.Combine(Directory.GetCurrentDirectory(), "Furniture.db");
            options.UseSqlite($"Data Source={DbPath}");
        }
    }
}
