namespace MyShop.Data.Dto
{
    public class ProductDto
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        public ProductDto(string name, int price = 0, string description = "")
        {
            Name = name;
            Price = price;
            Description = description;
        }
    }
}
