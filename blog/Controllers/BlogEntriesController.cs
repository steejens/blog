using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{
    public class BlogEntriesController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Blog Entries";
            return View();
        }
    }
}
