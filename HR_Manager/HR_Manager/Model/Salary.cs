namespace HR_Manager.Model
{
    public class Salary
    {
        public int SalaryValue { get; set; }
        public Employee Employee { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime LastDate { get; set; }

        public int EmployeeNumber { get; set; }
    }
}
