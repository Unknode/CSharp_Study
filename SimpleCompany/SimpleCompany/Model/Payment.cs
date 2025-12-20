using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCompany.Model
{
    [Table("payments")]
    public class Payment
    {
        [Column("customerNumber")]
        [Key]
        public int CustomerNumber { get; set; }

        [Column("checkNumber")]
        public string CheckNumber { get; set; }

        [Column("paymentDate")]
        public DateTime PaymentDate { get; set; }

        [Column("amount")]
        public decimal Amount { get; set; }
    }
}
