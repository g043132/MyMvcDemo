using MyStudy.MVCDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace MyStudy.MVCDemo.Data
{
    public class MvcMovieContext:DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options):base(options)
        {

        }
        public DbSet<Movie> Movie {get; set;}
        public DbSet<Singer> Singer {get; set;}
        public DbSet<Product> Product {get; set;} 
    }
}