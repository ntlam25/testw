using Microsoft.AspNetCore.Mvc;

namespace vphone.Controllers.Site
{
    public class SearchController : Controller
    {
        [Route("/search")]
        public IActionResult Index()
        {
            return View("~/Views/Site/Search/Index.cshtml");
        }
    }
}
