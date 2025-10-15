using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Manager.Model
{
    [Table("employees")]
    public class Employee
    {
        [Column("emp_no")]
        public int EmployeeNumber { get; set; }
        [Column("birth_date")]
        public DateTime BirthDate { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("gender")]
        public GenderEnum Gender { get; set; }
        [Column("hire_date")]
        public DateTime HireDate { get; set; }

       
        // relation N to N
        public ICollection<Departament> Departaments { get; set; }

        // relation 1 to N
        public ICollection<Title> Titles { get; set; }

        // relation 1 to N
        public ICollection<Salary> Salaries { get; set; }
    }
}
