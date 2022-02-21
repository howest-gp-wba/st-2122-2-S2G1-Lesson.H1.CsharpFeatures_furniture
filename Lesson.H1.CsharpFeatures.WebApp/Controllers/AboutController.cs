using Microsoft.AspNetCore.Mvc;

namespace Lesson.H1.CsharpFeatures.WebApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search(string searchkey)
        {
            return View(); //todo: create a view named “Search” under Views/Home }
        }
    }
}
