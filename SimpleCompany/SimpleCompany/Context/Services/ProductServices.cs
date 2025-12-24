using SimpleCompany.Model;

namespace SimpleCompany.Context.Services
{
    public class ProductServices
    {
        private SimpleCompanyContext _context;

        public ProductServices(SimpleCompanyContext context)
        {
            _context = context;
        }

        public Product GetProduct(string id)
        {
            return _context.Products.FirstOrDefault(x => x.ProductCode == id);
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public void DeleteProduct(string id)
        {
            var productToDelete = GetProduct(id);

            _context.Products.Remove(productToDelete);
            _context.SaveChanges();
        }

        public Product UpdateProductLine(Product product)
        {
            if (product == null)
                return null;

            _context.Products.Update(product);
            _context.SaveChanges();

            return product;
        }
    }
}
