using API.ContextObject;
using API.IRepositories;
using SharedLibrary.DTO;
using System.Linq.Expressions;

namespace API.Repositories
{
    public class MenuItemRepository : GeneralRepository<MenuItem>, IMenuItemRepository
    {
        public MenuItemRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
