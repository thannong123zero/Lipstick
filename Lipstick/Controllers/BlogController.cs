using Microsoft.AspNetCore.Mvc;

namespace Lipstick.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult<List<Object>> Index()
        {
            var blogs = new List<Object>

            {
            };
            return View(blogs);
        }
    }
}
