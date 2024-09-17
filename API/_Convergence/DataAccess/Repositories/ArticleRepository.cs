using API._Convergence.DataAccess.ContextObject;
using API._Convergence.DataAccess.IRepositories;
using SharedLibrary.DTO;

namespace API._Convergence.DataAccess.Repositories
{
    public class ArticleRepository : GenericRepository<Article>, IArticleRepository
    {
        public ArticleRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
