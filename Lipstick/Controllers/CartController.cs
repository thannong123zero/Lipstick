using Microsoft.AspNetCore.Mvc;

namespace Lipstick.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
