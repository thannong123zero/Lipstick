using Microsoft.AspNetCore.Mvc;

namespace Lipstick.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
