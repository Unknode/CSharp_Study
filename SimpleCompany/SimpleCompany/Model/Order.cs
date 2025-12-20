using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCompany.Model
{
    [Table("Orders")]
    public class Order
    {
        [Column("orderNumber")]
        [Key]
        public int OrderNumber { get; set; }

        [Column("orderDate")]
        public DateTime OrderDate { get; set; }

        [Column("requiredDate")]
        public DateTime RequiredDate { get; set; }

        [Column("shippedDate")]
        public DateTime? ShippedDate { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("comments")]
        public string? Comments { get; set; }


        public Customer Customer { get; set; }
        public int CustomerNumber { get; set; }
    }
}
