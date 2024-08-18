using CRM.Helpers;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.UserInterfaceDTO;

namespace CRM.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductHelper _productHelper;
        public ProductController(ProductHelper productHelper)
        {
            _productHelper = productHelper;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<ProductUI> data = await _productHelper.GetProducts();
            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ProductUI model = new ProductUI();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProductUI model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _productHelper.CreateProduct(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(string ID)
        {
            ProductUI data = await _productHelper.GetProductByID(ID);
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(ProductUI model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _productHelper.UpdateProduct(model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete()
        {
            return View();
        }
    }
}
