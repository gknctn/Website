using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
