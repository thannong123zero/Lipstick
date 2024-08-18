using CRM.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SharedLibrary.DTO;
using SharedLibrary.UserInterfaceDTO;

namespace CRM.Controllers
{
    public class MenuItemController : Controller
    {
        private readonly MenuGroupHelper _menuGroupHelper;
        private readonly MenuItemHelper _menuItemHelper;
        public MenuItemController(MenuGroupHelper menuGroupHelper, MenuItemHelper menuItemHelper)
        {
            _menuGroupHelper = menuGroupHelper;
            _menuItemHelper = menuItemHelper;
        }
        [HttpGet]
        public async Task<IActionResult> Index(string menuGroupID = "")
        {
            MenuGroupUI seletedMenuGroup = new MenuGroupUI();
            IEnumerable<MenuGroupUI> menuGroupList = await _menuGroupHelper.GetMenuGroups();
            ViewBag.MenuGroupList = menuGroupList;
            if (string.IsNullOrEmpty(menuGroupID))
            {
                seletedMenuGroup = menuGroupList.First();
                menuGroupID = seletedMenuGroup.ID.ToString();
            }
            else
            {
                Guid ID = Guid.Parse(menuGroupID);
                seletedMenuGroup = menuGroupList.Where(s => s.ID == ID).FirstOrDefault();
            }
            ViewBag.Selected = seletedMenuGroup.NameVN;
            IEnumerable<MenuItemUI> data = await _menuItemHelper.GetMenuItems(menuGroupID);

            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> Create(string menuGroupID)
        {
            IEnumerable<MenuGroupUI> menuGroupList = await _menuGroupHelper.GetMenuGroups();
            ViewBag.MenuGroupList = new SelectList(menuGroupList, "ID", "NameVN",menuGroupID);
            MenuItemUI model = new MenuItemUI();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(MenuItemUI model)
        {
            IEnumerable<MenuGroupUI> menuGroupList = await _menuGroupHelper.GetMenuGroups();
            ViewBag.MenuGroupList = new SelectList(menuGroupList, "ID", "NameVN");
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _menuItemHelper.CreateMenuItem(model);
            return RedirectToAction("Index", new { menuGroupID = model.MenuGroupID });
        }
        [HttpGet]
        public async Task<IActionResult> Update(string ID)
        {
            IEnumerable<MenuGroupUI> menuGroupList = await _menuGroupHelper.GetMenuGroups();
            ViewBag.MenuGroupList = new SelectList(menuGroupList, "ID", "NameVN");
            if (string.IsNullOrEmpty(ID))
            {
                return RedirectToAction("Index");
            }
            MenuItemUI data = await _menuItemHelper.GetMenuItemByID(ID);
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(MenuItemUI model)
        {
            IEnumerable<MenuGroupUI> menuGroupList = await _menuGroupHelper.GetMenuGroups();
            ViewBag.MenuGroupList = new SelectList(menuGroupList, "ID", "NameVN");
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _menuItemHelper.UpdateMenuItem(model);
            return RedirectToAction("Index", new { menuGroupID  = model.MenuGroupID});
        }
        [HttpPost]
        public async Task<IActionResult> Delete(string ID)
        {
            return View();
        }
    }
}
