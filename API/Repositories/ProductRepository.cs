using API.ContextObject;
using API.IRepositories;
using SharedLibrary.DTO;

namespace API.Repositories
{
    public class ProductRepository : GeneralRepository<Product>, IProductRepository
    {
        public ProductRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
