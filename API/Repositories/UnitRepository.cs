using API.ContextObject;
using API.IRepositories;
using SharedLibrary.DTO;

namespace API.Repositories
{
    public class UnitRepository : GeneralRepository<Unit>, IUnitRepository
    {
        public UnitRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
