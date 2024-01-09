using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Pricing
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string? NameOfService { get; set; }
        [Required]
        [MaxLength(50)]
        public int? LengthOfSession { get; set; }
        [Required]
        [MaxLength(50)]
        public int? Price { get; set; }
        [Required]
        [MaxLength(50)]
        public string? ListOfIncluded { get; set; }
    }
}
