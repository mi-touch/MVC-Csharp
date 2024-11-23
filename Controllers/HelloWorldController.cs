using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // Default action: renders the Index view
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = $"Hello {name}";
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
