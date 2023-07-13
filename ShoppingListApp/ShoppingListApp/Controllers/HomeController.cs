using Microsoft.AspNetCore.Mvc;

namespace ShoppingListApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Index = "active";
            ViewBag.IndexCss = "Index";
            return View();
        }
    }
}
