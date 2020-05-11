using Microsoft.EntityFrameworkCore;
using MyStudy.Razor3.Models;
namespace MyStudy.Razor3.Data
{
    public class RazorPagesMovieContext:DbContext
    {
        public RazorPagesMovieContext(DbContextOptions<RazorPagesMovieContext> options):base(options)
        {

        }
        public DbSet<Movie> Movie{get;set; }
    }
}