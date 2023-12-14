using FurnitureUtility.Data;
using Microsoft.EntityFrameworkCore;


namespace FurnitureDatabaseUtility.Data
{
    internal class FurnitureDbContext : DbContext
    {
        public DbSet<FurnitureCollection> Collection { get; set; }
        public string DbPath { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer($"Data Source={DbPath}");
        }
        
        public FurnitureDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "blogging.db");
        }
    }
}
