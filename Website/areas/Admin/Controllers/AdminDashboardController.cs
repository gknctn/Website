using Microsoft.AspNetCore.Mvc;

namespace Website.areas.Admin.Controllers
{
    public class AdminDashboardController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
