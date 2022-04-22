using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "About Us";
            return View();
        }
    }
}
