using SimpleCompany.Model;

namespace SimpleCompany.Context.Services
{
    public class OfficeServices
    {
        private SimpleCompanyContext _context;

        public OfficeServices (SimpleCompanyContext context)
        {
            _context = context;
        }

        public Office GetOffice(string id)
        {
            return _context.Offices.FirstOrDefault(x => x.OfficeCode == id);
        }

        public List<Office> GetOffices()
        {
            return _context.Offices.ToList();
        }

        public void DeleteOffice(string id)
        {
            var officeToDelete = GetOffice(id);

            _context.Offices.Remove(officeToDelete);
            _context.SaveChanges();
        }

        public Office UpdateOffice(Office office)
        {
            if (office == null)
                return null;

            _context.Offices.Update(office);
            _context.SaveChanges();

            return office;
        }
    }
}
