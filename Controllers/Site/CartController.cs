using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using vphone.Helper;
using Nop.Services.Catalog;
using vphone.Models;

namespace vphone.Controllers.Site
{
    public class CartController : Controller
    {
        private QLQuanDTContext db;
        public CartController(QLQuanDTContext db)
        {
            this.db = db;
        }

        [Route("/cart")]
        public IActionResult Index()
        {
            return View("~/Views/Site/Cart/Index.cshtml");
        }

        public void AddItem(int productId)
        {
            var cart = HttpContext.Session.Get<Cart>("Cart") ?? new Cart();
            // Tìm sản phẩm theo productId và thêm vào giỏ hàng
            var product = db.Products.FirstOrDefault(p => p.Id == productId);   
            if (product != null)
            {
                var existingItem = cart.Items.FirstOrDefault(item => item.ProductId == productId);
                if (existingItem != null)
                {
                    existingItem.Qty++;
                }
                else
                {
                    cart.Items.Add(new CartItem
                    {
                        ProductId = productId,
                        Name = product.Name,
                        Image = product.Image,
                        Price = product.Price,
                        Qty = 1
                    });
                }
                HttpContext.Session.Set("Cart", cart);
            }
            //return RedirectToAction("Index");
        }

        [Route("/add-to-cart/{id}")]
        public IActionResult AddToCart(int id)
        {
            AddItem(id);
            return View("~/Views/Site/Home/Index.cshtml");
        }

        [Route("/buy-now/{id}")]
        public IActionResult BuyNow(int id)
        {
            AddItem(id);
            return View("~/Views/Site/Cart/Index.cshtml");
        }


    }
}
