using Microsoft.AspNetCore.Mvc;

namespace vphone.Controllers.Site
{
    public class ProductController : Controller
    {
        [Route("/product")]
        public IActionResult Index()
        {
            return View("~/Views/Site/ProductDetail/Index.cshtml");
        }
    }
}
