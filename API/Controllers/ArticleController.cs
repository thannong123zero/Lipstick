using API.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.UserInterfaceDTO;

namespace API.Controllers
{
    [Route("api/Article")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly ArticleHelper _articleHelper;
        public ArticleController(ArticleHelper articleHelper)
        {
            _articleHelper = articleHelper;
        }
        [HttpGet]
        [Route("getArticles")]
        public async Task<IActionResult> GetArticles()
        {
            IEnumerable<ArticleUI> data = await _articleHelper.GetArticles();
            if (data == null)
            {
                return BadRequest();
            }
            await _articleHelper.GetArticles();
            return Ok(data);
        }
        [HttpGet]
        [Route("getArticleByID")]
        public async Task<IActionResult> GetArticleByID(string ID)
        {
            ArticleUI data = await _articleHelper.GetArticleByID(ID);
            if (data == null)
            {
                return BadRequest();
            }
            return Ok(data);
        }
        [HttpPost]
        [Route("addArticle")]
        public async Task<IActionResult> AddArticle([FromBody] ArticleUI model)
        {
            if (model == null)
            {
                return BadRequest();
            }
            await _articleHelper.AddArticle(model);
            return Ok();
        }
        [HttpPut]
        [Route("updateArticle")]
        public async Task<IActionResult> UpdateArticle([FromBody] ArticleUI model)
        {
            if (model == null)
            {
                return BadRequest();
            }
            await _articleHelper.UpdateArticle(model);

            return Ok();
        }
        [HttpDelete]
        [Route("deleteArticle")]
        public async Task<IActionResult> DeleteArticleByID(string ID)
        {
            if (ID == null)
            {
                return BadRequest();
            }
            await _articleHelper.DeleteArticleByID(ID);
            return Ok();
        }
        //[HttpGet]
        //[Route("checkPermissionToDelete")]
        //public async Task<IActionResult> CheckPermissionToDelete(string ID)
        //{
        //    DatabaseOjectResult databaseOjectResult = new DatabaseOjectResult();
        //    databaseOjectResult.OK = await _articleHelper.CheckPermissionToDelete(ID);
        //    return Ok(databaseOjectResult);
        //}
        [HttpDelete]
        [Route("softDeleteArticle")]
        public async Task<IActionResult> SoftDeleteArticleByID(string ID)
        {
            if (ID == null)
            {
                return BadRequest();
            }
            await _articleHelper.SoftDeleteArticleByID(ID);

            return Ok();
        }
        [HttpPatch]
        [Route("restoreArticle")]
        public async Task<IActionResult> RestoreArticleByID(string ID)
        {
            if (ID == null)
            {
                return BadRequest();
            }
            await _articleHelper.RestoreArticleByID(ID);

            return Ok();
        }
    }
}
