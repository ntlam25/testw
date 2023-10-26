using Microsoft.AspNetCore.Mvc;
using vphone.Models;
using vphone.Controllers;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Information;
//using System.Web.Mvc;

namespace vphone.Controllers.Admin
{
    public class UserController : Controller
    {
        private QLQuanDTContext db;

        public UserController(QLQuanDTContext db)
        {
            this.db = db;
        }

        [Route("/admin/user")]
        public IActionResult Index()
        {
            var users = db.Users.ToList();
            return View("~/Views/Admin/User/listuser.cshtml", users);
        }
        public IActionResult Add()
        {
            var user = new List<SelectListItem>();
            foreach (var item in db.Users)
            {
                user.Add(new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                });
            }
            ViewBag.Id = user;
            ViewBag.Id = new SelectList(db.Users, "Id", "Name");
            return View("~/views/admin/user/adduser.cshtml");
        }
        
        [Route("/admin/user/add")]
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Add([Bind("Email,Password,Name,Address,Phone")] User user)
        {
            if(ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id = new SelectList(db.Users, "Id","Name");
            return View("~/Views/Admin/User/adduser.cshtml");
        }

        public IActionResult Edit(int? id)
        {
            if(id==null || db.Users == null)
            {
                return NotFound();
            }
            var users = db.Users.Find(id);
            if (users == null)
            {
                return NotFound();
            }
            ViewBag.Id = new SelectList(db.Users, "Id","Name", users.Id);
            return View("~/Views/Admin/User/edituser.cshtml");
        }
        [Route("/admin/user/edit/{id}")]
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Edit(int? id, [Bind("Email,Password,Name,Address,Phone")] User user)
        {
            if(id != user.Id)
            {
                return NotFound();
            }
            if(ModelState.IsValid)
            {
                try
                {
                    db.Update(user);
                    db.SaveChanges();
                }
                catch(DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id)){
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

            }
            ViewBag.Id = new SelectList(db.Users, "Id", "Name", user.Id);
            return View("~/Views/Admin/User/edituser.cshtml");
        }
        private bool UserExists(int id) 
        { 
            return (db.Users?.Any(e=> e.Id == id)).GetValueOrDefault();
        }
    }
}