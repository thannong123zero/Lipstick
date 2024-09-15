using API._Convergence.DataAccess.ContextObject;
using API._Convergence.DataAccess.IRepositories;
using SharedLibrary.DTO;

namespace API._Convergence.DataAccess.Repositories
{
    public class UnitRepository : GenericRepository<Unit>, IUnitRepository
    {
        public UnitRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
