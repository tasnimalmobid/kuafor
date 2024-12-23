using Microsoft.AspNetCore.Mvc;

namespace WebApplication8.Controllers
{
    public class Home1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
