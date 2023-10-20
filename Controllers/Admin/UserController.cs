using Microsoft.AspNetCore.Mvc;
using vphone.Models;

namespace vphone.Controllers.Admin
{
	public class UserController : Controller
	{
        private QLQuanDTContext db;

        public UserController (QLQuanDTContext db)
        {
            this.db = db;
        }   

        [Route("/admin/user")]
        public IActionResult Index()
        {
            var users = db.Users.ToList();
            return View("~/Views/Admin/User/listuser.cshtml", users);
        }

        [Route("/admin/user/add")]
        public IActionResult Add()
        {
            return View("~/Views/Admin/User/adduser.cshtml");
        }

        [Route("/admin/user/edit")]
        public IActionResult Edit()
        {
            return View("~/Views/Admin/User/edituser.cshtml");
        }
    }
}
