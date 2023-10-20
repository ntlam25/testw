using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vphone.Models;

namespace vphone.Controllers.Admin
{
	public class ProductController : Controller
	{
        private QLQuanDTContext db;
        public ProductController(QLQuanDTContext db)
        {
            this.db = db;   
        }
		[Route("/admin/product")]
		public IActionResult Index()
		{
            var products = db.Products.Include(m => m.Cat).ToList();
			return View("~/Views/Admin/Product/listproduct.cshtml", products);
		}

        [Route("/admin/product/add")]
        public IActionResult Add()
        {
            return View("~/Views/Admin/Product/addproduct.cshtml");
        }

        [Route("/admin/product/edit/{slug}/{id}")]
        public IActionResult Edit(int id)
        {
            
            var product = db.Products.FirstOrDefault(p => p.Id == id);
            return View("~/Views/Admin/Product/editproduct.cshtml", product);
        }
    }
}
