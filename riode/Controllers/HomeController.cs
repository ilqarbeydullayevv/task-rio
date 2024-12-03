using Microsoft.AspNetCore.Mvc;

namespace riode.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
