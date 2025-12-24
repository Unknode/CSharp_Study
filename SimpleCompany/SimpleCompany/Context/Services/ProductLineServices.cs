using SimpleCompany.Model;

namespace SimpleCompany.Context.Services
{
    public class ProductLineServices
    {
        private SimpleCompanyContext _context;

        public ProductLineServices(SimpleCompanyContext context)
        {
            _context = context;
        }

        public ProductLine GetProductLine(string id)
        {
            return _context.ProductLines.FirstOrDefault(x => x.ProductL == id);
        }

        public List<ProductLine> GetProductLines()
        {
            return _context.ProductLines.ToList();
        }

        public void DeleteProductLine(string id)
        {
            var productLineToDelete = GetProductLine(id);

            _context.ProductLines.Remove(productLineToDelete);
            _context.SaveChanges();
        }

        public ProductLine UpdateProductLine(ProductLine productLine)
        {
            if (productLine == null)
                return null;

            _context.ProductLines.Update(productLine);
            _context.SaveChanges();

            return productLine;
        }
    }
}
