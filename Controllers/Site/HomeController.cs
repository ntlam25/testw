using Microsoft.AspNetCore.Mvc;

namespace vphone.Controllers.Site
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Site/Home/Index.cshtml");
        }
    }
}
