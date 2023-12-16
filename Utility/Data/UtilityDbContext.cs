using Microsoft.EntityFrameworkCore;

public class UtilityDbContext : DbContext
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
    public List<ElementPrice> Prices { get; } = new();

    public FurnitureElement() { }
    public FurnitureElement(string collectionId, string elementId, string name)
    {
        CollectionId = collectionId;
        ElementId = elementId;
        Name = name;
        Description = string.Empty;
    }
}

public class ElementPrice
{
    public int Id { get; set; }
    public string ElementId { get; set; }
    public int Category { get; set; } 
    public int Price { get; set; }

    public ElementPrice() { }
    public ElementPrice(string elementId,int category, int price)
    {
        ElementId = elementId;
        Category = category;
        Price = price;
    }
}
