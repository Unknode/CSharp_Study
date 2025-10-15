using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Manager.Model
{
    [Table("salaries")]
    public class Salary
    {
        [Column("salary")]
        public int SalaryValue { get; set; }
        [Column("from_date")]
        public DateTime FromDate { get; set; }
        [Column("to_date")]
        public DateTime ToDate { get; set; }

        [Column("emp_no")]
        public int EmployeeNumber { get; set; }
        public Employee Employee { get; set; }
    }
}
