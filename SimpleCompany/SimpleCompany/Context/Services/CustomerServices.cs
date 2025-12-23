using SimpleCompany.Context;
using SimpleCompany.Model;

namespace SimpleCompany.Context.Services
{
    public class CustomerServices
    {

        private readonly SimpleCompanyContext _context;

        public CustomerServices(SimpleCompanyContext context)
        {
            _context = context;
        }

        public Customer GetCustomer(int customerNumber)
        {
            return _context.Customers.FirstOrDefault(x => x.CustomerNumber == customerNumber);
        }
        public List<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }

        public void DeleteCustomer (int id) {

            var customerToDelete = GetCustomer(id);
            _context.Customers.Remove(customerToDelete);

            _context.SaveChanges();
        }

        public Customer UpdateCustomer(Customer customer) {

            if (customer == null)
                return null;

            _context.Customers.Update(customer);
            _context.SaveChanges();

            return customer;
        }
    }
}
