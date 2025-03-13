using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;

namespace RetailWebApp_1.Models
{
    public class Product
    {
        [Column(TypeName = "int")]
        [Key]
        public int ProductId { get; set; }

        [Column(TypeName = "varchar(25)")]
        [Required]
        public string ProductName { get; set; } = "";

        [Column(TypeName = "varchar(100)")]
        public string? Description { get; set; }

        [Column(TypeName = "varchar(25)")]
        public string? Brand { get; set; }

        [Column(TypeName = "varchar(25)")]
        public string? Size { get; set; }

        [Column(TypeName = "varchar(25)")]
        public string? Colour { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public int CategoryId { get; set; }

        [Column(TypeName = "Decimal(6, 2)")]
        [Required]
        public double? UnitPrice { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string? Image { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public int StaffId { get; set; }



    }
}
