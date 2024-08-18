using CRM.Helpers;
using CRM.Services.APIServices;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.UserInterfaceDTO;
using System.Reflection;
using System.Security;
using System.Security.Permissions;

namespace CRM.Controllers
{
    public class MenuGroupController : Controller
    {
        private readonly MenuGroupHelper _menuGroupHelper;
        public MenuGroupController(MenuGroupHelper menuGroupHelper)
        {
            _menuGroupHelper = menuGroupHelper;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<MenuGroupUI> data = await _menuGroupHelper.GetMenuGroups();
            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            MenuGroupUI model = new MenuGroupUI();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(MenuGroupUI model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _menuGroupHelper.CreateMenuGroup(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(string ID)
        {
            MenuGroupUI data = await _menuGroupHelper.GetMenuGroupByID(ID);
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(MenuGroupUI model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _menuGroupHelper.UpdateMenuGroup(model);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<DatabaseOjectResult> CheckPermissionToDelete(string ID)
        {
            DatabaseOjectResult databaseOjectResult = new DatabaseOjectResult();
            databaseOjectResult.OK = true;
            databaseOjectResult.Content = "Cai nay duoc phep xoa!"+ID;
            return databaseOjectResult;
        }

        /// <summary>
        /// Action delete The Category
        /// Step 1: Giu yeu cau kiem tra xem co danh muc con khong ?
        /// Step 2: Neu co thi khong cho xoa
        /// Step 2.1: Neu khong co thi cho xoa
        /// Step 3: Thong bao trang thai
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<DatabaseOjectResult> Delete(string ID)
        {
            DatabaseOjectResult databaseOjectResult = new DatabaseOjectResult();
            databaseOjectResult.OK = await _menuGroupHelper.SoftDelete(ID);
            return databaseOjectResult;
        }
    }
}
