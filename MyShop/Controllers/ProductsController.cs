using Microsoft.AspNetCore.Mvc;
using MyShop.Data;
using MyShop.Services;

namespace MyShop.Controllers
{
    public class ProductsController : ApiController
    {

        [HttpPost]
        public ActionResult AddProduct([FromBody] Product product)
        {
            var repository = new ProductRepository();
            repository.AddProductAsync(product);

            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult> GetProduct([FromBody] int id)
        {
            var repository = new ProductRepository();
            var product = await repository.GetProductAsync(id);

            if(product == null)
            {
                return BadRequest();
            }
            
            return Ok(product);
        }
    }
}
