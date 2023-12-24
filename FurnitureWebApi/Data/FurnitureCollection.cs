namespace FurnitureWebApi.Data
{
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
}
