using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCompany.Model
{
    [Table("products")]
    public class Product
    {
        [Column("productCode")]
        [Key]
        public string ProductCode { get; set; }

        [Column("productName")]
        public string ProductName { get; set; }

        [Column("productLine")]
        public string ProductLine { get; set; }

        [Column("productScale")]
        public string ProductScale { get; set; }

        [Column("productVendor")]
        public string ProductVendor { get; set; }

        [Column("productDescription")]
        public string ProductDescription { get; set; }

        [Column("quantityInStock")]
        public int QuantityInStock { get; set; }

        [Column("buyPrice")]
        public decimal BuyPrice { get; set; }

        [Column("MSRP")]
        public decimal MSRP { get; set; }
    }
}
