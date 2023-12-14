using Microsoft.EntityFrameworkCore;

public class UtilityDbContext : DbContext
{
    public DbSet<FurnitureCollection> Collections { get; set; }
    public DbSet<FurnitureElement> Elements { get; set; }
    public string DbPath { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        DbPath = Path.Combine(Directory.GetCurrentDirectory(), "Furniture.db");
        options.UseSqlite($"Data Source={DbPath}");
    }
}

public class FurnitureCollection
{
    public int Id { get; set; }
    public string CollectionId { get; set; }
    public string Name { get; set; }

    public List<FurnitureElement> Elements { get; } = new();

    public FurnitureCollection() { }
    public FurnitureCollection(string id, string name)
    {
        CollectionId = id;
        Name = name;
    }
}

public class FurnitureElement
{
    public int Id { get; set; }
    public string ElementId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string CollectionId { get; set; }

    public FurnitureElement() { }
    public FurnitureElement(string id, string name, string description, string collectionId)
    {
        ElementId = collectionId + "." + id;
        Name = name;
        Description = description;
        CollectionId = collectionId;
    }

}
