using Microsoft.AspNetCore.Mvc;
using vphone.Models;

namespace vphone.Controllers.Site
{
    public class ProductController : Controller
    {
        private QLQuanDTContext db;
        public ProductController(QLQuanDTContext context)
        {
            db=context;
        }
        [Route("/product/{id}")]

        public IActionResult Index(int? id)
        {
            var product = db.Products
                .Where(p => p.Id == id);
            return View("~/Views/Site/ProductDetail/Index.cshtml",product);
        }
    }
}
