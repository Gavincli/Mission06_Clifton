using Mission06_Clifton.Models;
using System.ComponentModel.DataAnnotations;

namespace Mission06_Clifton.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public List<Movie>? Movies { get; set; }
    }
}
