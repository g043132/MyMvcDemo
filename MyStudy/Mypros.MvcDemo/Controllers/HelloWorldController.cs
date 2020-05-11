using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Mypros.MvcDemo.Controllers
{
    public class HelloWorldController: Controller
    {
        // 
        // GET: /HelloWorld/

        // public string Index()
        // {
        //     // return "This is my default action...";
        //     return View();
        // }

        public IActionResult Index()
        {
            return View();
             
        }

        public IActionResult Hello()
        {
            return View();
        }


        // 
        // GET: /HelloWorld/Welcome/ 

        // public string Welcome()
        // {
        //     return "This is the Welcome action method...";
        // }
        // Requires using System.Text.Encodings.Web;
        // public string Welcome(string name, int numTimes = 1)
        // {
        //     // return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //     string s=string.Format($"Hello {name}, NumTimes is: {numTimes}");
        //     return s;
        // }

         public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        
    }
}