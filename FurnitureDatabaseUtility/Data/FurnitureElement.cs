using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureDatabaseFiller.Data
{
    internal class FurnitureElement
    {
        public List<string> Images { get; set; }
        public int[] Prices { get; set; }

        public string Id { get;}  
        public string Name { get;}
        public string Scheme { get;}
        

        public FurnitureElement(string id, string name, string scheme)
        {
            Id = id;
            Name = name;
            Scheme = scheme;
            Images = new List<string>();
            Prices = new int[10];
        }
    }
}
