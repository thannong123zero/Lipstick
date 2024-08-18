using Newtonsoft.Json;
using SharedLibrary.UserInterfaceDTO;
using System.Text;

namespace CRM.Services.APIServices
{
    public class ArticleAPIService
    {
        private readonly AppConfig _appConfig;
        public ArticleAPIService(AppConfig appConfig)
        {
            _appConfig = appConfig;
        }
        /// <summary>
        /// Get menugroups
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ArticleUI>> GetArticles()
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string getArticlesUrl = _appConfig.GetArticlesUrl;
            //string url = string.Concat(baseLink,getArticlesUrl);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                HttpResponseMessage response = await httpClient.GetAsync(getArticlesUrl);
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the response content to ArticleUI objects
                    string responseData = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(responseData))
                    {
                        IEnumerable<ArticleUI> articles = JsonConvert.DeserializeObject<IEnumerable<ArticleUI>>(responseData);
                        // Return the fetched menu groups
                        return articles;
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
        public async Task<ArticleUI> GetArticleByID(string ID)
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string getArticleByIDUrl = _appConfig.GetArticleByIDUrl;
            string url = string.Concat(getArticleByIDUrl, ID);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);

                HttpResponseMessage response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the response content to ArticleUI objects
                    string responseData = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(responseData))
                    {
                        ArticleUI article = JsonConvert.DeserializeObject<ArticleUI>(responseData);
                        // Return the fetched menu groups
                        return article;
                    }
                }
            }

            return null;
        }
        /// <summary>
        /// Create Article
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task CreateArticle(ArticleUI model)
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string addArticleUrl = _appConfig.AddArticleUrl;
            //string url = string.Concat(baseLink,getArticlesUrl);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                string json = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(addArticleUrl, content);
            }
        }
        /// <summary>
        /// Update Article
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task UpdateArticle(ArticleUI model)
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string updateArticleUrl = _appConfig.UpdateArticleUrl;
            //string url = string.Concat(baseLink,getArticlesUrl);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                string json = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync(updateArticleUrl, content);
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
            string softDeleteArticleUrl = _appConfig.SoftDeleteArticleUrl;
            string url = string.Concat(softDeleteArticleUrl, ID);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                HttpResponseMessage response = await httpClient.DeleteAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the response content to ArticleUI objects
                    string responseData = await response.Content.ReadAsStringAsync();
                    return true;
                }
            }
            return false;
        }
    }
}
