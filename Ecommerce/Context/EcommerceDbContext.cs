using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Context
{
    public class EcommerceDbContext:DbContext
    {
        public EcommerceDbContext(DbContextOptions options) : base(options) 
        {
             
        }

        public EcommerceDbContext()
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories{ get; set; }

    }
}
