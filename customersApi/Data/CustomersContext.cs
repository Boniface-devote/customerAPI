using customersApi.Models;
using Microsoft.EntityFrameworkCore;

namespace customersApi.Data
{
    public class CustomersContext : DbContext
    {
        public CustomersContext(DbContextOptions<CustomersContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
