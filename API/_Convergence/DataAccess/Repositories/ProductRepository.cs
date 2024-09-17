using API._Convergence.DataAccess.ContextObject;
using API._Convergence.DataAccess.IRepositories;
using SharedLibrary.DTO;

namespace API._Convergence.DataAccess.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
