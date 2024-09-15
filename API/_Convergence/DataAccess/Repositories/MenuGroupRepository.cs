using API._Convergence.DataAccess.ContextObject;
using API._Convergence.DataAccess.IRepositories;
using Microsoft.EntityFrameworkCore;
using SharedLibrary.DTO;

namespace API._Convergence.DataAccess.Repositories
{
    public class MenuGroupRepository : GenericRepository<MenuGroup>, IMenuGroupRepository
    {
        public MenuGroupRepository(DatabaseContext dbContext) : base(dbContext) { }
    }
}
