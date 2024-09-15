using API._Convergence.DataAccess.ContextObject;
using API._Convergence.DataAccess.IRepositories;
using SharedLibrary.DTO;

namespace API._Convergence.DataAccess.Repositories
{
    public class BrandRepository : GenericRepository<Brand>, IBrandRepository
    {
        public BrandRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
