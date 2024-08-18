using API.ContextObject;
using API.IRepositories;
using SharedLibrary.DTO;

namespace API.Repositories
{
    public class TopicRepository : GeneralRepository<Topic>, ITopicRepository
    {
        public TopicRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
