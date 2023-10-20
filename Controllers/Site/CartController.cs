using Microsoft.AspNetCore.Mvc;

namespace vphone.Controllers.Site
{
    public class CartController : Controller
    {
        [Route("/cart")]
        public IActionResult Index()
        {
            return View("~/Views/Site/Cart/Index.cshtml");
        }
    }
}
