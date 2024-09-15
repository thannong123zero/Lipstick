using API._Convergence.DataAccess.ContextObject;
using API._Convergence.DataAccess.IRepositories;
using SharedLibrary.DTO;
using System.Linq.Expressions;

namespace API._Convergence.DataAccess.Repositories
{
    public class MenuItemRepository : GenericRepository<MenuItem>, IMenuItemRepository
    {
        public MenuItemRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
