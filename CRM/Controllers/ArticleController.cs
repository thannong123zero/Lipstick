using CRM.Helpers;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.UserInterfaceDTO;

namespace CRM.Controllers
{
    public class ArticleController : Controller
    {
        private readonly ArticleHelper _articleHelper;
        public ArticleController(ArticleHelper articleHelper)
        {
            _articleHelper = articleHelper;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<ArticleUI> data = await _articleHelper.GetArticles();
            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ArticleUI model = new ArticleUI();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(ArticleUI model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _articleHelper.CreateArticle(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(string ID)
        {
            ArticleUI data = await _articleHelper.GetArticleByID(ID);
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(ArticleUI model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _articleHelper.UpdateArticle(model);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string ID)
        {
            return View();
        }
    }
}
