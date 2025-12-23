using SimpleCompany.Model;

namespace SimpleCompany.Context.Services
{
    public class EmployeeServices
    {
        private SimpleCompanyContext _context;

        public EmployeeServices(SimpleCompanyContext context)
        {
            _context = context;
        }

        public Employee GetEmployee(int id)
        {
            return _context.Employees.FirstOrDefault(x => x.EmployeeNumber == id);
        }

        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }

        public void DeleteEmployee(int id)
        {
            var employeetoDelete = GetEmployee(id);

            _context.Employees.Remove(employeetoDelete);
            _context.SaveChanges();
        }

        public Employee UpdateEmployee(Employee employee) 
        {
            if (employee == null)
                return null;

            _context.Employees.Update(employee);
            _context.SaveChanges();

            return employee;
        }
    }
}
