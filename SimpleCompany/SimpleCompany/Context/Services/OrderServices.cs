using SimpleCompany.Model;

namespace SimpleCompany.Context.Services
{
    public class OrderServices
    {
        private SimpleCompanyContext _context;

        public OrderServices(SimpleCompanyContext context)
        {
            _context = context;
        }

        public Order GetOrder(int id)
        {
            return _context.Orders.FirstOrDefault(x => x.OrderNumber == id);
        }

        public List<Order> GetOrders()
        {
            return _context.Orders.ToList();
        }

        public void DeleteOrders(int id)
        {
            var orderToDelete = GetOrder(id);

            _context.Orders.Remove(orderToDelete);
            _context.SaveChanges();
        }

        public Order UpdateOrder(Order order)
        {
            if (order == null)
                return null;

            _context.Orders.Update(order);
            _context.SaveChanges();

            return order;
        }
    }
}
