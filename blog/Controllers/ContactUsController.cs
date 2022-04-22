using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{
    public class ContactUsController :Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Contact Us";
            return View();
        }
    }
}
