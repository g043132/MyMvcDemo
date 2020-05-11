using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyStudy.MVCDemo.Data;
using MyStudy.MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace MyStudy.MVCDemo.Controllers
{
    public class MoviesController: Controller
    {

        private readonly MvcMovieContext _context;

        public MoviesController(MvcMovieContext context)
        {
            _context = context;
        }
        // public  async Task<IActionResult> Index()
        // {

        //     var movies = await _context.Movie.ToListAsync();
        //     return View(movies);
        // }

        public async Task<IActionResult> Index(string id)
        {
            var movies = from m in _context.Movie
                        select m;

            if (!String.IsNullOrEmpty(id))
            {
                movies = movies.Where(s => s.Title.Contains(id));
            }

            return View(await movies.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Index(string searchString, bool notUsed)
        {
              var movies = from m in _context.Movie
                        select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title.Contains(searchString));
            }

            return View(await movies.ToListAsync());
        }

        [HttpPost]
        public string IndexTest(string searchString, bool notUsed)
        {
              var movies = from m in _context.Movie
                        select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title.Contains(searchString));
            }
           return JsonHelper.SerializeJSON<IEnumerable<Movie>>((IEnumerable<Movie>)movies);
        }
        

          public IActionResult Create()
          {
                return View();
          }

          [HttpPost]
         public async Task<IActionResult> Create(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _context.Attach(movie).State = EntityState.Added;

            try
            {
                 if (!MovieExists(movie.Id))
                 {
                    _context.Movie.Add(movie);
                    await _context.SaveChangesAsync();
                 }
              
            }
            catch (DbUpdateConcurrencyException)
            {
                
                
            }

            return RedirectToAction("Index","Movies");
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return View();
            }

            return View(movie);
        }

         public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return View();
            }

            return View(movie);
        }

         [HttpPost]
         public async Task<IActionResult> Edit(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _context.Attach(movie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(movie.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToAction("Index","Movies");
        }

        private bool MovieExists(int id)
        {
            return _context.Movie.Any(e => e.Id == id);
        }

        public async Task<IActionResult> Delete(int? id)
        {
             Movie movie = await _context.Movie.FindAsync(id);

            if (movie != null)
            {
                _context.Movie.Remove(movie);
                await _context.SaveChangesAsync();
            }
             return RedirectToAction("Index","Movies");
        }


        


        // 
        // GET: /HelloWorld/Welcome/ 

        // public string Welcome()
        // {
        //     return "This is the Welcome action method...";
        // }
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int numTimes = 1)
        {
            // return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
            string s=string.Format($"Hello {name}, NumTimes is: {numTimes}");
            return s;
        }

        

        
    }
}