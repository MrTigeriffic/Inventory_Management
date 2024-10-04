using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory_management.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(100)")]
        public string ProductName { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "int")]
        public int Quantity { get; set; }
    }
}
