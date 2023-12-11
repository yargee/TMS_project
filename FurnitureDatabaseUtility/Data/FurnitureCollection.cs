using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureDatabaseFiller.Data
{
    internal class FurnitureCollection
    {
        private List<FurnitureElement> _elements { get;} = new List<FurnitureElement>();

        public string Id { get; set; }
        public string Name { get; set; }
        

        public FurnitureCollection(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddElement(FurnitureElement element)
        {
            _elements.Add(element);
        }
    }
}
