using Newtonsoft.Json;
using SharedLibrary.UserInterfaceDTO;
using System.Text;

namespace CRM.Services.APIServices
{
    public class MenuItemAPIService
    {
        private readonly AppConfig _appConfig;
        public MenuItemAPIService(AppConfig appConfig)
        {
            _appConfig = appConfig;
        }
        /// <summary>
        /// Get menugroups
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<MenuItemUI>> GetMenuItems(string menuGroupID)
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string getMenuItemsUrl = _appConfig.GetMenuItemsUrl;
            string url = string.Concat(getMenuItemsUrl, menuGroupID);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                HttpResponseMessage response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the response content to MenuItemUI objects
                    string responseData = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(responseData))
                    {
                        IEnumerable<MenuItemUI> menuItems = JsonConvert.DeserializeObject<IEnumerable<MenuItemUI>>(responseData);
                        // Return the fetched menu groups
                        return menuItems;
                    }
                }
            }
            return null;
        }
        /// <summary>
        /// Get menu group by ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public async Task<MenuItemUI> GetMenuItemByID(string ID)
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string getMenuItemByIDUrl = _appConfig.GetMenuItemByIDUrl;
            string url = string.Concat(getMenuItemByIDUrl, ID);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);

                HttpResponseMessage response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the response content to MenuItemUI objects
                    string responseData = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(responseData))
                    {
                        MenuItemUI menuItem = JsonConvert.DeserializeObject<MenuItemUI>(responseData);
                        // Return the fetched menu groups
                        return menuItem;
                    }
                }
            }

            return null;
        }
        /// <summary>
        /// Create MenuItem
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task CreateMenuItem(MenuItemUI model)
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string addMenuItemUrl = _appConfig.AddMenuItemUrl;
            //string url = string.Concat(baseLink,getMenuItemsUrl);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                string json = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(addMenuItemUrl, content);
            }
        }
        /// <summary>
        /// Update MenuItem
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task UpdateMenuItem(MenuItemUI model)
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string updateMenuItemUrl = _appConfig.UpdateMenuItemUrl;
            //string url = string.Concat(baseLink,getMenuItemsUrl);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                string json = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync(updateMenuItemUrl, content);
            }
        }
        /// <summary>
        /// Soft delele
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public async Task<bool> SoftDelete(string ID)
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string softDeleteMenuItemUrl = _appConfig.SoftDeleteMenuItemUrl;
            string url = string.Concat(softDeleteMenuItemUrl, ID);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                HttpResponseMessage response = await httpClient.DeleteAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the response content to MenuItemUI objects
                    string responseData = await response.Content.ReadAsStringAsync();
                    return true;
                }
            }
            return false;
        }
    }
}
