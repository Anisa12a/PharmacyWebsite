using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyWebsite.Entities
{
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; } = string.Empty;

        [Required]
        [MaxLength(350)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string Category { get; set; } = string.Empty;

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Quantity { get; set; } = string.Empty;

        [Required]
        public string Manufacturer { get; set; } = string.Empty;

        [Required]
        public string DosageForm { get; set; } = string.Empty;

        [Required]
        public int QuantityInStock { get; set; }
    }
}
