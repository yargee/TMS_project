using System.ComponentModel.DataAnnotations;

namespace FurnitureUtility.Data
{
    internal class FurnitureElement
    {
        //public List<string> Images { get; set; }
        //public int[] Prices { get; set; }

        [Key]
        public string Id { get;}  
        public string Name { get;}
        public string Scheme { get;}
    }
}
