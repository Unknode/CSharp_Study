namespace HR_Manager.Model
{
    public class Employee
    {
        public int EmployeeNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderEnum Gender { get; set; }
        public DateTime HireDate { get; set; }
    }
}
