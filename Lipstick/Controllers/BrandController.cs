using Microsoft.AspNetCore.Mvc;

namespace Lipstick.Controllers
{
    public class BrandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
