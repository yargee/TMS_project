namespace FurnitureDatabaseFiller.Data
{
    internal class FurnitureCollection
    {
        public List<FurnitureElement> Elements { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        

        public FurnitureCollection(string id, string name)
        {
            Id = id;
            Name = name;
            Elements = new List<FurnitureElement>();
        }
    }
}
