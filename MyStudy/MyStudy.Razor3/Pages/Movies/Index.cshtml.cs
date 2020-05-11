using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyStudy.Razor3.Data;
using MyStudy.Razor3.Models;

namespace MyStudy.Razor3.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MyStudy.Razor3.Data.RazorPagesMovieContext _context;

        public IndexModel(MyStudy.Razor3.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
