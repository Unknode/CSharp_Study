using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCompany.Model
{
    [Table("Customers")]
    public class Customer
    {
        [Column("customerNumber")]
        [Key]
        public int CustomerNumber { get; set; }

        [Column("customerName")]
        public string CustomerName { get; set; }

        [Column("contactLastName")]
        public string ContactLastName { get; set; }

        [Column("contactFirstName")]
        public string ContactFirstName { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("addressLine1")]
        public string PrimaryAddress { get; set; }

        [Column("addressLine2")]
        public string? SecondaryAddress { get; set; }

        [Column("state")]
        public string? State { get; set; }

        [Column("postalCode")]
        public string? PostalCode { get; set; }

        [Column("country")]
        public string Country { get; set; }
        [Column("salesRepEmployeeNumber")]
        public int? SalesRepresentativeEmployeeNumber { get; set; }

        [Column("creditLimit")]
        public decimal? CreditLimit { get; set; }
      
    }
}
