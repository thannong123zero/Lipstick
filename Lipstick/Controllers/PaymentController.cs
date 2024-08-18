using Microsoft.AspNetCore.Mvc;

namespace Lipstick.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
