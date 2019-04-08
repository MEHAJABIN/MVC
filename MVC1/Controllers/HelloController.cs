
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Mvc1.Controllers
{
    public class HelloController : Controller
    {
        // 
        // GET: /HelloWorld/

         /*------ public string Index()
          {

              return "Welcome To My Page" ;
          }

          // 
          // GET: /HelloWorld/Welcome/ 

          /*  public string Welcome()
            {
                return "My Page";
            }*/
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
      /*   public string Welcome(string name="Sam")
         {
             return HtmlEncoder.Default.Encode($"Hello {name}");
         }*/


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
        public async Task<IActionResult> Index(string searchString)
        {
            var movies = from m in _context.Movie
                         select m;
                       

            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title.Contains(searchString));
            }

            return View(await movies.ToListAsync());
        }
    }
}