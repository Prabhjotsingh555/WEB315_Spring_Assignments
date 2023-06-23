using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cars.Models
{
    public class cars1
    {
        public int ID { get; set; }
        
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime BuildYear { get; set; }

        [Range(1, 100000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^.{1,2}$", ErrorMessage = "Rating must be 1 or 2 characters long.")]
        [Required]
        public int Rating { get; set; }

        [StringLength(60, MinimumLength = 4)]
        [Required]
        public string Name { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Company must contain only letters and white spaces.")]
        [Required]
        [StringLength(30)]
        public string Company { get; set; }
        
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Engine must contain only letters and white spaces.")]
        [Required]
        [StringLength(30)]
        public string Engine { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Country must contain only letters and white spaces.")]
        [Required]
        [StringLength(30)]
        public string Country { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Features must contain only letters and white spaces.")]
        [Required]
        [StringLength(30)]
        public string Features { get; set; }   

        [RegularExpression(@"^[A-Z][a-zA-Z\s]*$", ErrorMessage = "Colour must start with an uppercase letter and contain only letters and white spaces.")]
        [Required]
        public string Colour { get; set; }
    }
}
