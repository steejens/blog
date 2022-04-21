using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{
    [Route("test/api")]
    public class HomeController : Controller
    {
        [HttpPost("person")]
        public IActionResult Index()
        {
            ViewBag.Title = "Blog - Home";
            return View();
        }
    }
}
