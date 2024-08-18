using Microsoft.AspNetCore.Mvc;

namespace CRM.Controllers
{
    public class InvoiceController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
