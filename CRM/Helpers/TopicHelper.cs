using CRM.Services.APIServices;
using SharedLibrary.UserInterfaceDTO;

namespace CRM.Helpers
{
    public class TopicHelper
    {
        private readonly TopicAPIService _APIService;
        public TopicHelper(TopicAPIService aPIService)
        {
            _APIService = aPIService;
        }

        public async Task<IEnumerable<TopicUI>> GetTopics()
        {
            return await _APIService.GetTopics();
        }
        public async Task<TopicUI> GetTopicByID(string ID)
        {
            return await _APIService.GetTopicByID(ID);
        }
        public async Task CreateTopic(TopicUI model)
        {
            await _APIService.CreateTopic(model);
        }
        public async Task UpdateTopic(TopicUI model)
        {
            await _APIService.UpdateTopic(model);
        }
        public async Task<bool> SoftDelete(string ID)
        {
            return await _APIService.SoftDelete(ID);
        }
    }
}
