using API.ContextObject;
using API.IRepositories;
using SharedLibrary.DTO;

namespace API.Repositories
{
    public class BrandRepository : GeneralRepository<Brand>, IBrandRepository
    {
        public BrandRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
