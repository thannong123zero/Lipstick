using CRM.Helpers;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.UserInterfaceDTO;

namespace CRM.Controllers
{
    public class UnitController : Controller
    {
        private readonly UnitHelper _unitHelper;
        public UnitController(UnitHelper unitHelper) {
        _unitHelper = unitHelper;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<UnitUI> data = await _unitHelper.GetUnits();
            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            UnitUI model = new UnitUI();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(UnitUI model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _unitHelper.CreateUnit(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(string ID)
        {
            UnitUI data = await _unitHelper.GetUnitByID(ID);
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UnitUI model)
        {
            if(!ModelState.IsValid) { 
            return View(model);
            }
            await _unitHelper.UpdateUnit(model);
            return RedirectToAction("Index");
        }
    }
}
