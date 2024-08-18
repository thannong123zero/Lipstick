using CRM.Services.APIServices;
using SharedLibrary.UserInterfaceDTO;

namespace CRM.Helpers
{
    public class MenuItemHelper
    {
        private readonly MenuItemAPIService _APIService;
        public MenuItemHelper(MenuItemAPIService aPIService)
        {
            _APIService = aPIService;
        }

        public async Task<IEnumerable<MenuItemUI>> GetMenuItems(string menuGroupID)
        {
            return await _APIService.GetMenuItems(menuGroupID);
        }
        public async Task<MenuItemUI> GetMenuItemByID(string ID)
        {
            return await _APIService.GetMenuItemByID(ID);
        }
        public async Task CreateMenuItem(MenuItemUI model)
        {
            await _APIService.CreateMenuItem(model);
        }
        public async Task UpdateMenuItem(MenuItemUI model)
        {
            await _APIService.UpdateMenuItem(model);
        }
        public async Task<bool> SoftDelete(string ID)
        {
            return await _APIService.SoftDelete(ID);
        }
    }
}
