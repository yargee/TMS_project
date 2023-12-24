using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureWebApi.Data
{
    public class FurnitureElement
    {
        public int Id { get; set; }
        public string ElementId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey("FurnitureCollection")]
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
}
