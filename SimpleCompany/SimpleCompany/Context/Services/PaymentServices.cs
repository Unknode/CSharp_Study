using SimpleCompany.Model;

namespace SimpleCompany.Context.Services
{
    public class PaymentServices
    {
        private SimpleCompanyContext _context;

        public PaymentServices(SimpleCompanyContext context)
        {
            _context = context;
        }

        public Payment GetPayment(int customerId)
        {
            return _context.Payments.FirstOrDefault(x => x.CustomerNumber == customerId);
        }

        public List<Payment> GetPayments()
        {
            return _context.Payments.ToList();
        }

    
    }
}
