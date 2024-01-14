using Microsoft.EntityFrameworkCore;
using MyShop.Data;
using MyShop.Data.Dto;

namespace MyShop.Services
{
    public class ProductRepository : IProductRepository
    {
        private ProductDbContext _context;

        public ProductRepository()
        {
            _context = new ProductDbContext();
        }

        public async void AddProductAsync(Product product)
        {
            await _context.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async void RemoveProductAsync(int id)
        {
            var product = _context.Product.FindAsync(id);

            if (product != null)
            {
                _context.Remove(product);

                await _context.SaveChangesAsync();
            }
        }

        public async Task<ProductDto> GetProductAsync(int id)
        {
            var result = await _context.Product.FindAsync(id);

            var product = _context.Product
            .Include(p => p.Price)
            .Include(p => p.ProductInfo)
            .FirstOrDefault(p => p.Id == id);


            if (result != null)
            {
                var dto = new ProductDto(result.Name, result.Price.RetailPrice, result.ProductInfo.Description);

                return dto;
            }

            return null;
        }
    }
}
