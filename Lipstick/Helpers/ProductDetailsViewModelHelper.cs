using Microsoft.AspNetCore.Mvc;

namespace Lipstick.Helpers
{
    public class ProductDetailsViewModelHelper : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
