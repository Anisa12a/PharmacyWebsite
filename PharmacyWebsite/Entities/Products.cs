using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyWebsite.Entities
{
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public string name { get; set; } = string.Empty;

        [Required]
        [MaxLength(350)]
        public string description { get; set; } = string.Empty;

        [Required]
        public string imageURL { get; set; } = string.Empty;
    }
}
