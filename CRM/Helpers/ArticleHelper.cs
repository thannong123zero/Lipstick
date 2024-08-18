using CRM.Services.APIServices;
using SharedLibrary.UserInterfaceDTO;

namespace CRM.Helpers
{
    public class ArticleHelper
    {
        private readonly ArticleAPIService _APIService;
        public ArticleHelper(ArticleAPIService aPIService)
        {
            _APIService = aPIService;
        }

        public async Task<IEnumerable<ArticleUI>> GetArticles()
        {
            return await _APIService.GetArticles();
        }
        public async Task<ArticleUI> GetArticleByID(string ID)
        {
            return await _APIService.GetArticleByID(ID);
        }
        public async Task CreateArticle(ArticleUI model)
        {
            await _APIService.CreateArticle(model);
        }
        public async Task UpdateArticle(ArticleUI model)
        {
            await _APIService.UpdateArticle(model);
        }
        public async Task<bool> SoftDelete(string ID)
        {
            return await _APIService.SoftDelete(ID);
        }
    }
}
