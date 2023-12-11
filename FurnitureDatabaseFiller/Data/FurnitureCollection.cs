using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureDatabaseFiller.Data
{
    internal class FurnitureCollection
    {
        public string CollectionId { get; set; }
        public string CollectionName { get; set; }
        public List<FurnitureElement> Elements {get;set;}
    }
}
