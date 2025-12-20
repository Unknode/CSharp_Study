using SimpleCompany.Context;
using SimpleCompany.Model;

namespace SimpleCompany.Services
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
    }
}
