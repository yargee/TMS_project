using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureWebApi.Data
{
    public class ElementPrice
    {
        public int Id { get; set; }

        [ForeignKey("FurnitureElement")]
        public string ElementId { get; set; }
        public int Category { get; set; }
        public int Price { get; set; }

        public ElementPrice() { }
        public ElementPrice(string elementId, int category, int price)
        {
            ElementId = elementId;
            Category = category;
            Price = price;
        }
    }
}
