using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureDatabaseFiller.Data
{
    internal class FurnitureElement
    {
        private List<string> _images { get;} = new List<string>();

        public string Id { get;}  
        public string Name { get;}
        public string Scheme { get;}
        

        public FurnitureElement(string id, string name, string scheme)
        {
            Id = id;
            Name = name;
            Scheme = scheme;
        }

        public void AddImage(string path)
        {
            _images.Add(path);
        }
    }
}
