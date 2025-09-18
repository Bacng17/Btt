using Microsoft.AspNetCore.Mvc;

namespace btt3.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewData["LayoutType"] = "Admin";
            return View();
        }
    }

}
