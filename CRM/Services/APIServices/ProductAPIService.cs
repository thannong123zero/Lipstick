using Newtonsoft.Json;
using SharedLibrary.UserInterfaceDTO;
using System.Text;

namespace CRM.Services.APIServices
{
    public class ProductAPIService
    {
        private readonly AppConfig _appConfig;
        public ProductAPIService(AppConfig appConfig)
        {
            _appConfig = appConfig;
        }
        /// <summary>
        /// Get menugroups
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ProductUI>> GetProducts()
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string getProductsUrl = _appConfig.GetProductsUrl;
            //string url = string.Concat(baseLink,getProductsUrl);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                HttpResponseMessage response = await httpClient.GetAsync(getProductsUrl);
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the response content to ProductUI objects
                    string responseData = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(responseData))
                    {
                        IEnumerable<ProductUI> products = JsonConvert.DeserializeObject<IEnumerable<ProductUI>>(responseData);
                        // Return the fetched menu groups
                        return products;
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
        public async Task<ProductUI> GetProductByID(string ID)
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string getProductByIDUrl = _appConfig.GetProductByIDUrl;
            string url = string.Concat(getProductByIDUrl, ID);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);

                HttpResponseMessage response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the response content to ProductUI objects
                    string responseData = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(responseData))
                    {
                        ProductUI product = JsonConvert.DeserializeObject<ProductUI>(responseData);
                        // Return the fetched menu groups
                        return product;
                    }
                }
            }

            return null;
        }
        /// <summary>
        /// Create Product
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task CreateProduct(ProductUI model)
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string addProductUrl = _appConfig.AddProductUrl;
            //string url = string.Concat(baseLink,getProductsUrl);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                string json = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(addProductUrl, content);
            }
        }
        /// <summary>
        /// Update Product
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task UpdateProduct(ProductUI model)
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string updateProductUrl = _appConfig.UpdateProductUrl;
            //string url = string.Concat(baseLink,getProductsUrl);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                string json = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync(updateProductUrl, content);
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
            string softDeleteProductUrl = _appConfig.SoftDeleteProductUrl;
            string url = string.Concat(softDeleteProductUrl, ID);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                HttpResponseMessage response = await httpClient.DeleteAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the response content to ProductUI objects
                    string responseData = await response.Content.ReadAsStringAsync();
                    return true;
                }
            }
            return false;
        }
    }
}
