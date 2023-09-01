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
                .OrderBy(p => p.ProductId) 
                .Take(20) // We write this line to get the first 20 products
                .ToListAsync();

            var productsList = products.Select(p => new ProductsModel
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                Description = p.Description,
                Category = p.Category,
                Price = p.Price,
                Manufacturer = p.Manufacturer,
                DosageForm = p.DosageForm,
                QuantityInStock = p.QuantityInStock
            }).ToList();

            return Ok(productsList);
        }
    }
}
