using Microsoft.AspNetCore.Mvc;

namespace Lipstick.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
