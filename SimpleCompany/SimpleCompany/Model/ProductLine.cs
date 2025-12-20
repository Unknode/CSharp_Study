using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCompany.Model
{
    [Table("productlines")]
    public class ProductLine
    {
        [Column("productLine")]
        [Key]
        public string ProductL { get; set; }

        [Column("textDescription")]
        public string? TextDescription { get; set; }

        [Column("htmlDescription")]
        public string HTMLDescription { get; set; }
    }
}
