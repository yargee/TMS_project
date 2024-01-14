using MyShop.Data;
using MyShop.Data.Dto;

namespace MyShop.Services
{
    public interface IProductRepository
    {
        public void AddProductAsync(Product product);
        public void RemoveProductAsync(int id);
        public Task<ProductDto> GetProductAsync(int id);
    }
}
