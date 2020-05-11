using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mypros.MvcDemo.Data;
using Mypros.MvcDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Mypros.MvcDemo.Controllers
{
    public class ProductsController: Controller
    {

        private readonly MvcMovieContext _context;

        public ProductsController(MvcMovieContext context)
        {
            _context = context;
        }
      
        public async Task<IActionResult> Index(string id)
        {
            var products = from m in _context.Product
                        select m;

            if (!String.IsNullOrEmpty(id))
            {
                products = products.Where(s => s.Title.Contains(id));
            }

            return View(await products.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Index(string searchString, bool notUsed)
        {
              var products = from m in _context.Product
                        select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Title.Contains(searchString));
            }

            return View(await products.ToListAsync());
        }

        [HttpPost]
        public string IndexTest(string searchString, bool notUsed)
        {
              var products = from m in _context.Product
                        select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Title.Contains(searchString));
            }
           return JsonHelper.SerializeJSON<IEnumerable<Product>>((IEnumerable<Product>)products);
        }
        //Statistics
        public IActionResult Statistics()
        {
            return View();
        }
                
    }
}