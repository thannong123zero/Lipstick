using API.Repositories;
using AutoMapper;
using SharedLibrary.DTO;
using SharedLibrary.UserInterfaceDTO;

namespace API.Helpers
{
    public class ArticleHelper
    {
        private UnitOfWork _unitOfWork;
        private IMapper _mapper;
        public ArticleHelper(IMapper mapper, UnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;

        }
        public async Task<IEnumerable<ArticleUI>> GetArticles()
        {
            var listArticle = await _unitOfWork.ArticleRepository.GetAll();
            if (listArticle == null)
            {
                return null;
            }
            listArticle = listArticle.OrderBy(s => s.ModifiedOn);
            IEnumerable<ArticleUI> listArticleUI = new List<ArticleUI>();
            listArticleUI = _mapper.Map<IEnumerable<ArticleUI>>(listArticle);

            return listArticleUI;
        }
        public async Task<ArticleUI> GetArticleByID(string ID)
        {
            if (!Guid.TryParse(ID, out var id))
            {
                return null;
            }
            var article = await _unitOfWork.ArticleRepository.GetById(Guid.Parse(ID));
            ArticleUI articleUI = _mapper.Map<ArticleUI>(article);
            return articleUI;
        }
        public async Task AddArticle(ArticleUI model)
        {
            try
            {
                Article entity = _mapper.Map<Article>(model);
                entity.ID = Guid.NewGuid();
                await _unitOfWork.ArticleRepository.Create(entity);
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task UpdateArticle(ArticleUI model)
        {
            try
            {
                Article article = await _unitOfWork.ArticleRepository.GetById(model.ID);
                if (article == null)
                {
                    return;
                }
                article.SubjectEN = model.SubjectEN;
                article.SubjectVN = model.SubjectVN;
                article.DescriptionEN = model.DescriptionEN;
                article.DescriptionVN = model.DescriptionVN;
                article.ModifiedOn = DateTime.Now;
                article.IsActive = model.IsActive;
                article.IsDeleted = model.IsDeleted;
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<bool> DeleteArticleByID(string ID)
        {
            Article article = await _unitOfWork.ArticleRepository.GetById(Guid.Parse(ID));

            if (article == null)
            {
                return false;
            }
            await _unitOfWork.ArticleRepository.Delete(Guid.Parse(ID));
            _unitOfWork.Save();
            return true;
        }
        public async Task<bool> SoftDeleteArticleByID(string ID)
        {
            var article = await _unitOfWork.ArticleRepository.GetById(Guid.Parse(ID));
            if (article == null)
            {
                return false;
            }
            article.IsDeleted = true;
            article.ModifiedOn = DateTime.Now;
            _unitOfWork.Save();
            return true;

        }
        //public async Task<bool> CheckPermissionToDelete(string ID)
        //{
        //    if (!Guid.TryParse(ID, out var id))
        //    {
        //        return false;
        //    }
        //    Article article = await _unitOfWork.ArticleRepository.GetById(Guid.Parse(ID));

        //    if (article != null && article.Products.Count <= 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        public async Task RestoreArticleByID(string ID)
        {
            var article = await _unitOfWork.ArticleRepository.GetById(Guid.Parse(ID));
            if (article != null)
            {
                article.IsDeleted = false;
                article.ModifiedOn = DateTime.Now;
                _unitOfWork.Save();
            }
        }
    }
}
