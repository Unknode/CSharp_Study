using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCompany.Model
{
    [Table("orderDetails")]
    public class OrderDetail
    {
        [Column("orderNumber")]
        [Key]
        public int OrderNumber { get; set; }

        [Column("productCode")]
        public string ProductCode { get; set; }

        [Column("quantityOrdered")]
        public int QuantityOrdered { get; set; }

        [Column("priceEach")]
        public decimal PriceEach { get; set; }

        [Column("orderLineNumber")]
        public int OrderLineNumber { get; set; }
    }
}
