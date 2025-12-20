using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCompany.Model
{
    [Table("offices")]
    public class Office
    {
        [Column("officeCode")]
        [Key]
        public string OfficeCode { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("addressLine1")]
        public string PrimaryAddress { get; set; }

        [Column("addressLine2")]
        public string? SecondaryAddress { get; set; }

        [Column("state")]
        public string? State { get; set; }

        [Column("country")]
        public string Country { get; set; }

        [Column("postalCode")]
        public string PostalCode { get; set; }

        [Column("territory")]
        public string Territory { get; set; }
    }
}
