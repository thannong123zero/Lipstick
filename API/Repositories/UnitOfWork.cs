using API.ContextObject;
using API.IRepositories;

namespace API.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private DatabaseContext context;
        private bool disposed = false;
        //MenuGroup
        private MenuGroupRepository menuGroupRepository;
        public MenuGroupRepository MenuGroupRepository
        {
            get
            {

                if (this.menuGroupRepository == null)
                {
                    this.menuGroupRepository = new MenuGroupRepository(context);
                }
                return menuGroupRepository;
            }
        }
        //MenuItem
        private MenuItemRepository menuItemRepository;
        public MenuItemRepository MenuItemRepository
        {
            get
            {

                if (this.menuItemRepository == null)
                {
                    this.menuItemRepository = new MenuItemRepository(context);
                }
                return menuItemRepository;
            }
        }
        //Unit
        private UnitRepository unitRepository;
        public UnitRepository UnitRepository
        {
            get
            {

                if (this.unitRepository == null)
                {
                    this.unitRepository = new UnitRepository(context);
                }
                return unitRepository;
            }
        }
        //Topic
        private TopicRepository topicRepository;
        public TopicRepository TopicRepository
        {
            get
            {

                if (this.topicRepository == null)
                {
                    this.topicRepository = new TopicRepository(context);
                }
                return topicRepository;
            }
        }
        //Brand
        private BrandRepository brandRepository;
        public BrandRepository BrandRepository
        {
            get
            {

                if (this.brandRepository == null)
                {
                    this.brandRepository = new BrandRepository(context);
                }
                return brandRepository;
            }
        }
        //Article
        private ArticleRepository articleRepository;
        public ArticleRepository ArticleRepository
        {
            get
            {

                if (this.articleRepository == null)
                {
                    this.articleRepository = new ArticleRepository(context);
                }
                return articleRepository;
            }
        }
        //Product
        private ProductRepository productRepository;
        public ProductRepository ProductRepository
        {
            get
            {

                if (this.productRepository == null)
                {
                    this.productRepository = new ProductRepository(context);
                }
                return productRepository;
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public UnitOfWork(DatabaseContext databaseContext)
        {
            context = databaseContext;
        }
    }
}
