using FurnitureDatabaseFiller.Data;
using Microsoft.EntityFrameworkCore;


namespace FurnitureDatabaseUtility.Data
{
    internal class FurnitureDbContext : DbContext
    {
        public DbSet<FurnitureCollection> Collection { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=furniture.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FurnitureCollection>().HasData(
                new FurnitureCollection("1", "Name1"),
                new FurnitureCollection("2", "Name2"),
                new FurnitureCollection("3", "Name3"),
                new FurnitureCollection("4", "Name4"));
        }
    }
}
