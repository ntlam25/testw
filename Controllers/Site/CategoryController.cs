using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace vphone.Controllers.Site
{
    public class CategoryController : Controller
    {
        [Route("/category")]
        public IActionResult Index()
        {
            return View("~/Views/Site/Category/Index.cshtml");
        }
    }
}
