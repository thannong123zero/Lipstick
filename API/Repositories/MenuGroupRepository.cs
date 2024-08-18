using API.ContextObject;
using API.IRepositories;
using Microsoft.EntityFrameworkCore;
using SharedLibrary.DTO;

namespace API.Repositories
{
    public class MenuGroupRepository : GeneralRepository<MenuGroup>, IMenuGroupRepository
    {
        public MenuGroupRepository(DatabaseContext dbContext):base(dbContext) { }
    }
}
