using Newtonsoft.Json;
using SharedLibrary.UserInterfaceDTO;
using System.Text;

namespace CRM.Services.APIServices
{
    public class UnitAPIService
    {
        private readonly AppConfig _appConfig;
        public UnitAPIService(AppConfig appConfig)
        {
            _appConfig = appConfig;
        }
        /// <summary>
        /// Get menugroups
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<UnitUI>> GetUnits()
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string getUnitsUrl = _appConfig.GetUnitsUrl;
            //string url = string.Concat(baseLink,getUnitsUrl);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                HttpResponseMessage response = await httpClient.GetAsync(getUnitsUrl);
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the response content to UnitUI objects
                    string responseData = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(responseData))
                    {
                        IEnumerable<UnitUI> units = JsonConvert.DeserializeObject<IEnumerable<UnitUI>>(responseData);
                        // Return the fetched menu groups
                        return units;
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
        public async Task<UnitUI> GetUnitByID(string ID)
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string getUnitByIDUrl = _appConfig.GetUnitByIDUrl;
            string url = string.Concat(getUnitByIDUrl, ID);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);

                HttpResponseMessage response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the response content to UnitUI objects
                    string responseData = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(responseData))
                    {
                        UnitUI unit = JsonConvert.DeserializeObject<UnitUI>(responseData);
                        // Return the fetched menu groups
                        return unit;
                    }
                }
            }

            return null;
        }
        /// <summary>
        /// Create Unit
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task CreateUnit(UnitUI model)
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string addUnitUrl = _appConfig.AddUnitUrl;
            //string url = string.Concat(baseLink,getUnitsUrl);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                string json = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(addUnitUrl, content);
            }
        }
        /// <summary>
        /// Update Unit
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task UpdateUnit(UnitUI model)
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string updateUnitUrl = _appConfig.UpdateUnitUrl;
            //string url = string.Concat(baseLink,getUnitsUrl);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                string json = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync(updateUnitUrl, content);
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
            string softDeleteUnitUrl = _appConfig.SoftDeleteUnitUrl;
            string url = string.Concat(softDeleteUnitUrl, ID);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                HttpResponseMessage response = await httpClient.DeleteAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the response content to UnitUI objects
                    string responseData = await response.Content.ReadAsStringAsync();
                    return true;
                }
            }
            return false;
        }
    }
}
