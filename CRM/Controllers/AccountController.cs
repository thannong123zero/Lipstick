using Microsoft.AspNetCore.Mvc;

namespace CRM.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
