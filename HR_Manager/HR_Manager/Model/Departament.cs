using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Manager.Model
{
    [Table("departaments")]
    public class Departament
    {
        [Column("dept_no")]
        public string DepartamentNumber { get; set; }

        [Column("dept_name")]
        public string Name { get; set; }

        // Relation 1 to N 
       public ICollection<Employee> Employees { get; set; }
    }
}
