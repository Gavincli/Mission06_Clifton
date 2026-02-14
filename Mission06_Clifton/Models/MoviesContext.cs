using Microsoft.EntityFrameworkCore;

namespace Mission06_Clifton.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base (options) //Constructor
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
