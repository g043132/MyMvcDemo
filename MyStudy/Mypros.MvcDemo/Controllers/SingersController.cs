using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mypros.MvcDemo.Data;
using Mypros.MvcDemo.Models;
using System;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Mypros.MvcDemo.Controllers
{
    public class SingersController: Controller
    {

        private readonly MvcMovieContext _context;

        public SingersController(MvcMovieContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(string id)
        {
            var singers = from m in _context.Singer
                        select m;

            if (!String.IsNullOrEmpty(id))
            {
                singers = singers.Where(s => s.Name.Contains(id));
            }

            return View(await singers.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Index(string searchString, bool notUsed)
        {
              var singers = from m in _context.Singer
                        select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                singers = singers.Where(s => s.Name.Contains(searchString));
            }

            return View(await singers.ToListAsync());
        }

          public IActionResult Create()
          {
                return View();
          }

          [HttpPost]
         public async Task<IActionResult> Create(Singer singer)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _context.Attach(singer).State = EntityState.Added;

            try
            {
                 if (!MovieExists(singer.Id))
                 {
                    _context.Singer.Add(singer);
                    await _context.SaveChangesAsync();
                 }
              
            }
            catch (DbUpdateConcurrencyException)
            {
                
                
            }

            return RedirectToAction("Index","Singers");
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var singer = await _context.Singer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (singer == null)
            {
                return View();
            }

            return View(singer);
        }

         public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var singer = await _context.Singer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (singer == null)
            {
                return View();
            }

            return View(singer);
        }

         [HttpPost]
         public async Task<IActionResult> Edit(Singer singer)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _context.Attach(singer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(singer.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

             return RedirectToAction("Index","Singers");
        }

        private bool MovieExists(int id)
        {
            return _context.Singer.Any(e => e.Id == id);
        }

        public async Task<IActionResult> Delete(int? id)
        {
             Singer singer = await _context.Singer.FindAsync(id);

            if (singer != null)
            {
                _context.Singer.Remove(singer);
                await _context.SaveChangesAsync();
            }
             return RedirectToAction("Index","Singers");
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