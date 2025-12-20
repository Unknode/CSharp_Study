using Microsoft.EntityFrameworkCore;
using SimpleCompany.Model;

namespace SimpleCompany.Context
{
    public class SimpleCompanyContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductLine> ProductLines { get; set; }

        public SimpleCompanyContext(DbContextOptions<SimpleCompanyContext> options) : base(options) { }
    }
}
