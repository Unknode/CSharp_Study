using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Manager.Model
{
    [Table("titles")]
    public class Title
    {
        [Column("title")]
        public string TitleName { get; set; }
        [Column("from_date")]
        public DateTime FromDate { get; set; }
        [Column("to_date")]
        public DateTime ToDate { get; set; }

        [Column("emp_no")]
        public int EmployeeNumber { get; set; }
        public Employee Employee { get; set; }
    }
}
