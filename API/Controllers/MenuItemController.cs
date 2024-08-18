using API.Helpers;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.UserInterfaceDTO;

namespace API.Controllers
{
    [Route("api/MenuItem")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        private readonly MenuItemHelper _menuItemHelper;
        public MenuItemController(MenuItemHelper menuItemHelper)
        {
            _menuItemHelper = menuItemHelper;
        }
        [HttpGet]
        [Route("getMenuItems")]
        public async Task<IActionResult> GetMenuItems(string menuGroupID = "")
        {
            if(!string.IsNullOrEmpty(menuGroupID) && !Guid.TryParse(menuGroupID, out Guid ID))
            {
                return BadRequest();
            }
            IEnumerable<MenuItemUI> data = await _menuItemHelper.GetMenuItems(menuGroupID);
            if (data == null)
            {
                return BadRequest();
            }
            return Ok(data);
        }
        [HttpGet]
        [Route("getMenuItemByID")]
        public async Task<IActionResult> GetMenuItemByID(string ID)
        {
            MenuItemUI data = await _menuItemHelper.GetMenuItemByID(ID);
            if (data == null)
            {
                return BadRequest();
            }
            return Ok(data);
        }
        [HttpPost]
        [Route("addMenuItem")]
        public async Task<IActionResult> AddMenuItem([FromBody] MenuItemUI model)
        {
            if (model == null)
            {
                return BadRequest();
            }
            await _menuItemHelper.AddMenuItem(model);
            return Ok();
        }
        [HttpPut]
        [Route("updateMenuItem")]
        public async Task<IActionResult> UpdateMenuItem([FromBody] MenuItemUI model)
        {
            if (model == null)
            {
                return BadRequest();
            }
            await _menuItemHelper.UpdateMenuItem(model);

            return Ok();
        }
        [HttpDelete]
        [Route("deleteMenuItem")]
        public async Task<IActionResult> DeleteMenuItemByID(string ID)
        {
            if (ID == null)
            {
                return BadRequest();
            }
            await _menuItemHelper.DeleteMenuItemByID(ID);
            return Ok();
        }
        [HttpGet]
        [Route("checkPermissionToDelete")]
        public async Task<IActionResult> CheckPermissionToDelete(string ID)
        {
            DatabaseOjectResult databaseOjectResult = new DatabaseOjectResult();
            databaseOjectResult.OK = await _menuItemHelper.CheckPermissionToDelete(ID);
            return Ok(databaseOjectResult);
        }
        [HttpDelete]
        [Route("softDeleteMenuItem")]
        public async Task<IActionResult> SoftDeleteMenuItemByID(string ID)
        {
            if (ID == null)
            {
                return BadRequest();
            }
            await _menuItemHelper.SoftDeleteMenuItemByID(ID);

            return Ok();
        }
        [HttpPatch]
        [Route("restoreMenuItem")]
        public async Task<IActionResult> RestoreMenuItemByID(string ID)
        {
            if (ID == null)
            {
                return BadRequest();
            }
            await _menuItemHelper.RestoreMenuItemByID(ID);

            return Ok();
        }
    }

}
