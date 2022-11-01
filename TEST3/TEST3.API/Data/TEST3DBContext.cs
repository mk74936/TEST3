using Microsoft.EntityFrameworkCore;
using TEST3.API.Models.Domain;

namespace TEST3.API.Data
{
    public class TEST3DBContext:DbContext
    {
        public TEST3DBContext(DbContextOptions<TEST3DBContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
