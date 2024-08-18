using Microsoft.AspNetCore.Mvc;

namespace Lipstick.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(string menuGroupID, string menuItemID)
        {

            return View();
        }
    }
}
