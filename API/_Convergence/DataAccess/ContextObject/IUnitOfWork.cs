using API._Convergence.DataAccess.IRepositories;

namespace API._Convergence.DataAccess.ContextObject
{
    public interface IUnitOfWork : IDisposable
    {
        IArticleRepository ArticleRepository { get; }
        IBrandRepository BrandRepository { get; }
        IMenuGroupRepository MenuGroupRepository { get; }
        IMenuItemRepository MenuItemRepository { get; }
        IProductRepository ProductRepository { get; }
        ITopicRepository TopicRepository { get; }
        IUnitRepository UnitRepository { get; }
        void BeginTransaction();
        void Commit();
        void Rollback();
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
