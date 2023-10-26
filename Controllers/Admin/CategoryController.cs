using Microsoft.AspNetCore.Mvc;
using vphone.Models;

namespace vphone.Controllers.Admin
{
    public class CategoryController : Controller
    {
        private QLQuanDTContext db;

        public CategoryController(QLQuanDTContext db)
        {
            this.db = db;
        }

        [Route("/admin/category")]
        public IActionResult Index()
        {
            var categories = db.Categories.ToList();
            return View("~/Views/Admin/Category/category.cshtml", categories);
        }

        [Route("/admin/category/add")]
        public IActionResult Add()
        {
            return View("~/Views/Admin/Category/addcategory.cshtml");
        }

        [Route("/admin/category/edit")]
        public IActionResult Edit()
        {
            return View("~/Views/Admin/Category/editcategory.cshtml");
        }
    }
}