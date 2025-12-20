using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCompany.Model
{
    [Table("Employees")]
    public class Employee
    {
        [Column("employeeNumber")]
        [Key]
        public int EmployeeNumber { get; set; }

        [Column("firstName")]
        public string FirstName { get; set; }

        [Column("lastName")]
        public string LastName { get; set; }

        [Column("extension")]
        public string Extension { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("officeCode")]
        public string OfficeCode { get; set; }

        [Column("reportsTo")]
        public int? ReportsTo { get; set; }

        [Column("jobTitle")]
        public string JobTitle { get; set; }
    }
}
