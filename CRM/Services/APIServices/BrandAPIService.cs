using Newtonsoft.Json;
using SharedLibrary.UserInterfaceDTO;
using System.Net.Http.Headers;
using System.Text;

namespace CRM.Services.APIServices
{
    public class BrandAPIService
    {
        private readonly AppConfig _appConfig;
        public BrandAPIService(AppConfig appConfig)
        {
            _appConfig = appConfig;
        }
        /// <summary>
        /// Get menugroups
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<BrandUI>> GetBrands()
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string getBrandsUrl = _appConfig.GetBrandsUrl;
            //string url = string.Concat(baseLink,getBrandsUrl);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                HttpResponseMessage response = await httpClient.GetAsync(getBrandsUrl);
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the response content to BrandUI objects
                    string responseData = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(responseData))
                    {
                        IEnumerable<BrandUI> brands = JsonConvert.DeserializeObject<IEnumerable<BrandUI>>(responseData);
                        return brands;
                    }
                }
            }
            return null;
        }
        /// <summary>
        /// Get brand by ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public async Task<BrandUI> GetBrandByID(string ID)
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string getBrandByIDUrl = _appConfig.GetBrandByIDUrl;
            string url = string.Concat(getBrandByIDUrl, ID);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);

                HttpResponseMessage response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the response content to BrandUI objects
                    string responseData = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(responseData))
                    {
                        BrandUI brand = JsonConvert.DeserializeObject<BrandUI>(responseData);
                        return brand;
                    }
                }
            }

            return null;
        }
        /// <summary>
        /// Create Brand
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task CreateBrand(BrandUI model)
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string addBrandUrl = _appConfig.AddBrandUrl;
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                //string json = JsonConvert.SerializeObject(model);
                //StringContent data = new StringContent(json, Encoding.UTF8, "application/json");
                MultipartFormDataContent content = new MultipartFormDataContent();
                // Add string properties
                content.Add(new StringContent(model.ID.ToString()), "ID");
                content.Add(new StringContent(model.NameEN), "NameEN");
                content.Add(new StringContent(model.NameVN), "NameVN");
                content.Add(new StringContent(model.Avatar), "Avatar");

                // Add optional string properties
                if (!string.IsNullOrEmpty(model.DescriptionEN))
                {
                    content.Add(new StringContent(model.DescriptionEN), "DescriptionEN");
                }
                if (!string.IsNullOrEmpty(model.DescriptionVN))
                {
                    content.Add(new StringContent(model.DescriptionVN), "DescriptionVN");
                }
                // Add file
                // If add sucessfully then we send else also we send 
                if (model.UploadImage != null)
                {
                    using (var streamContent = new StreamContent(model.UploadImage.OpenReadStream()))
                    {
                        streamContent.Headers.ContentType = new MediaTypeHeaderValue(model.UploadImage.ContentType);
                        content.Add(streamContent, "UploadImage", model.UploadImage.FileName);
                        HttpResponseMessage response = await httpClient.PostAsync(addBrandUrl, content);
                  }
                }
                else
                {
                    HttpResponseMessage response = await httpClient.PostAsync(addBrandUrl, content);
                }
            }
        }
        /// <summary>
        /// Update Brand
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task UpdateBrand(BrandUI model)
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string updateBrandUrl = _appConfig.UpdateBrandUrl;
            //string url = string.Concat(baseLink,getBrandsUrl);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                string json = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync(updateBrandUrl, content);
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
            string softDeleteBrandUrl = _appConfig.SoftDeleteBrandUrl;
            string url = string.Concat(softDeleteBrandUrl, ID);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                HttpResponseMessage response = await httpClient.DeleteAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the response content to BrandUI objects
                    string responseData = await response.Content.ReadAsStringAsync();
                    return true;
                }
            }
            return false;
        }
    }
}
