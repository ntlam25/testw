using Microsoft.AspNetCore.Mvc;

namespace vphone.Controllers.Site
{
    public class OrderController : Controller
    {
        [Route("/success")]
        public IActionResult Index()
        {
            return View("~/Views/Site/Success/Index.cshtml");
        }
    }
}
