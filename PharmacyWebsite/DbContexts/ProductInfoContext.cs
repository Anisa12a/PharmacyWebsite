using Microsoft.EntityFrameworkCore;
using PharmacyWebsite.Entities;

namespace PharmacyWebsite.DbContexts
{
    public class ProductInfoContext : DbContext
    {
        public DbSet<Products> Products { get; set; }

        public ProductInfoContext(DbContextOptions<ProductInfoContext> options) : base(options) 
        {
        }
    }
}
