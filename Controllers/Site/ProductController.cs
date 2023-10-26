using Microsoft.AspNetCore.Mvc;
using vphone.Models;

namespace vphone.Controllers.Site
{
    public class ProductController : Controller
    {
        private QLQuanDTContext db;
        public ProductController(QLQuanDTContext db)
        {
            this.db = db;
        }

            [Route("/product/{slug}/{id}")]
        public IActionResult Index(int id)
        {
            var product = db.Products.FirstOrDefault(x => x.Id == id);
            return View("~/Views/Site/ProductDetail/Index.cshtml", product);
        }
    }
}
