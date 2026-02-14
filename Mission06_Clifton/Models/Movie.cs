using System.ComponentModel.DataAnnotations;

namespace Mission06_Clifton.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }   // Primary Key

        [Required]
        public string Title { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public int Year { get; set; }      // Use int instead of DateOnly

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; } // Dropdown

        public bool? Edited { get; set; }   // optional

        public string? Lent { get; set; }   // optional

        [MaxLength(25)]
        public string? Notes { get; set; }  // optional, max 25
    }
}
