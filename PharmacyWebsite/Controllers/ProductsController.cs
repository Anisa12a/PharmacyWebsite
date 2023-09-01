using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PharmacyWebsite.DbContexts;
using PharmacyWebsite.Models;

namespace PharmacyWebsite.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductInfoContext _dbContext;

        public ProductsController(ProductInfoContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        //VIEW:

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductsModel>>> GetProducts()
        {
            var products = await _dbContext.Products
                .OrderBy(p => p.id) 
                .Take(20) // We write this line to get the first 20 products
                .ToListAsync();

            var productsList = products.Select(p => new ProductsModel
            {
                id = p.id,
                name = p.name,
                description = p.description,
                imageURL = p.imageURL
            }).ToList();

            return Ok(productsList);
        }
    }
}
