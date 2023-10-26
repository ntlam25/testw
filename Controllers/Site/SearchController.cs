using Microsoft.Ajax.Utilities;
using Microsoft.AspNetCore.Mvc;
using vphone.Models;

namespace vphone.Controllers.Site
{
    public class SearchController : Controller
    {
        private QLQuanDTContext db;
        public SearchController(QLQuanDTContext db)
        {
            this.db = db;
        }
        [HttpPost]
        [Route("/search")]
        public IActionResult Index(string keyword)
        {
            ViewBag.products = db.Products.Where(p => p.Name.ToLower().Contains(keyword.ToLower()));
            ViewBag.keyword = keyword;
            return View("~/Views/Site/Search/Index.cshtml", ViewBag);
        }
    }
}
