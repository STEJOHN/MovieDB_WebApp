using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options)
               : base(options)
        {
        }
        //Movie is name of DB in SQL
        public DbSet<Movies> Movie { get; set; }
    }
}