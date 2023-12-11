using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureDatabaseFiller.Data
{
    internal class FurnitureElement
    {
        public string Id { get; set; }  
        public string Name { get; set; }
        public string Scheme { get; set; }
        public List<string> Images { get; set; }
    }
}
