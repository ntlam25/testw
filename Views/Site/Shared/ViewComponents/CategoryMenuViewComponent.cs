using Microsoft.AspNetCore.Mvc;
using vphone.Models;

namespace vphone.Views.Site.ViewComponents
{
    public class CategoryMenuViewComponent : ViewComponent
    {
        QLQuanDTContext db;
        List<Category> categories;
        public CategoryMenuViewComponent(QLQuanDTContext context)
        {
            db = context;
            categories = db.Categories.ToList();
        }
        public IViewComponentResult Invoke()
        {
            return View("~/Views/Site/Shared/Components/CategoryMenu/Default.cshtml",categories);
        }
    }
}
