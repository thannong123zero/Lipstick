using Newtonsoft.Json;
using SharedLibrary.UserInterfaceDTO;
using System.Text;

namespace CRM.Services.APIServices
{
    public class TopicAPIService
    {
        private readonly AppConfig _appConfig;
        public TopicAPIService(AppConfig appConfig)
        {
            _appConfig = appConfig;
        }
        /// <summary>
        /// Get menugroups
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<TopicUI>> GetTopics()
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string getTopicsUrl = _appConfig.GetTopicsUrl;
            //string url = string.Concat(baseLink,getTopicsUrl);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                HttpResponseMessage response = await httpClient.GetAsync(getTopicsUrl);
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the response content to TopicUI objects
                    string responseData = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(responseData))
                    {
                        IEnumerable<TopicUI> topics = JsonConvert.DeserializeObject<IEnumerable<TopicUI>>(responseData);
                        // Return the fetched menu groups
                        return topics;
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
        public async Task<TopicUI> GetTopicByID(string ID)
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string getTopicByIDUrl = _appConfig.GetTopicByIDUrl;
            string url = string.Concat(getTopicByIDUrl, ID);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);

                HttpResponseMessage response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the response content to TopicUI objects
                    string responseData = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(responseData))
                    {
                        TopicUI topic = JsonConvert.DeserializeObject<TopicUI>(responseData);
                        // Return the fetched menu groups
                        return topic;
                    }
                }
            }

            return null;
        }
        /// <summary>
        /// Create Topic
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task CreateTopic(TopicUI model)
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string addTopicUrl = _appConfig.AddTopicUrl;
            //string url = string.Concat(baseLink,getTopicsUrl);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                string json = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(addTopicUrl, content);
            }
        }
        /// <summary>
        /// Update Topic
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task UpdateTopic(TopicUI model)
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string updateTopicUrl = _appConfig.UpdateTopicUrl;
            //string url = string.Concat(baseLink,getTopicsUrl);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                string json = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync(updateTopicUrl, content);
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
            string softDeleteTopicUrl = _appConfig.SoftDeleteTopicUrl;
            string url = string.Concat(softDeleteTopicUrl, ID);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                HttpResponseMessage response = await httpClient.DeleteAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the response content to TopicUI objects
                    string responseData = await response.Content.ReadAsStringAsync();
                    return true;
                }
            }
            return false;
        }
    }
}
