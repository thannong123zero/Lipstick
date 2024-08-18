using API.ContextObject;
using API.IRepositories;
using SharedLibrary.DTO;

namespace API.Repositories
{
    public class ArticleRepository : GeneralRepository<Article>, IArticleRepository
    {
        public ArticleRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
