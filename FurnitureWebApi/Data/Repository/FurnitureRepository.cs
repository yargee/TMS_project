namespace FurnitureWebApi.Data.Repository
{
    public class FurnitureRepository
    {
        private FurnitureDbContext _context;

        public FurnitureRepository(FurnitureDbContext context)
        {
            _context = context;
        }

        public void AddCollection(FurnitureCollection collection)
        {
            _context.AddAsync(collection);
            _context.SaveChangesAsync();
        }

        public void AddElement(FurnitureElement element)
        {
            var collection = _context.Collections.FirstOrDefault(x => (element.ElementId.Contains(x.CollectionId) || element.ElementId.Equals(x.CollectionId)));//equals нужен?
            
            if(collection == null)
            {
                _context.AddAsync(element);
                collection.Elements.Add(element);
                _context.SaveChangesAsync();
            }
        }

        public void RemoveCollection(string id)
        {
            var collection = _context.Collections.FirstOrDefault(x => x.CollectionId == id);

            if(collection != null)
            {
                _context.Remove(collection);
                _context.SaveChangesAsync();
            }
        }

        public void RemoveElement(string elementId)
        {
            var collection = _context.Collections.FirstOrDefault(x => (elementId.Contains(x.CollectionId) || elementId.Equals(x.CollectionId)));//equals нужен?
            
            if(collection!= null)
            {
                var element = collection.Elements.FirstOrDefault(x => x.ElementId == elementId);
                collection.Elements.Remove(element);
                _context.Remove(element);
                _context.SaveChangesAsync();
            }
        }
    }
}
