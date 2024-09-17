using API._Convergence.DataAccess.ContextObject;
using API._Convergence.DataAccess.IRepositories;
using SharedLibrary.DTO;

namespace API._Convergence.DataAccess.Repositories
{
    public class TopicRepository : GenericRepository<Topic>, ITopicRepository
    {
        public TopicRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
