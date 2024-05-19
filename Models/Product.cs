using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Range(0.01, 10000.00)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}