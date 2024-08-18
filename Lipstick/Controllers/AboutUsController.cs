using Microsoft.AspNetCore.Mvc;

namespace Lipstick.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
