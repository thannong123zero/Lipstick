using API.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.UserInterfaceDTO;

namespace API.Controllers
{
    [Route("api/Brand")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly BrandHelper _brandHelper;
        public BrandController(BrandHelper brandHelper)
        {
            _brandHelper = brandHelper;
        }
        [HttpGet]
        [Route("getBrands")]
        public async Task<IActionResult> GetBrands()
        {
            IEnumerable<BrandUI> data = await _brandHelper.GetBrands();
            if (data == null)
            {
                return BadRequest();
            }
            await _brandHelper.GetBrands();
            return Ok(data);
        }
        [HttpGet]
        [Route("getBrandByID")]
        public async Task<IActionResult> GetBrandByID(string ID)
        {
            BrandUI data = await _brandHelper.GetBrandByID(ID);
            if (data == null)
            {
                return BadRequest();
            }
            return Ok(data);
        }
        [HttpPost]
        [Route("addBrand")]
        public async Task<IActionResult> AddBrand([FromForm] BrandUI model)
        {
            if (model == null)
            {
                return BadRequest();
            }
            await _brandHelper.AddBrand(model);
            return Ok();
        }
        [HttpPut]
        [Route("updateBrand")]
        public async Task<IActionResult> UpdateBrand([FromBody] BrandUI model)
        {
            if (model == null)
            {
                return BadRequest();
            }
            await _brandHelper.UpdateBrand(model);

            return Ok();
        }
        [HttpDelete]
        [Route("deleteBrand")]
        public async Task<IActionResult> DeleteBrandByID(string ID)
        {
            if (ID == null)
            {
                return BadRequest();
            }
            await _brandHelper.DeleteBrandByID(ID);
            return Ok();
        }
        [HttpGet]
        [Route("checkPermissionToDelete")]
        public async Task<IActionResult> CheckPermissionToDelete(string ID)
        {
            DatabaseOjectResult databaseOjectResult = new DatabaseOjectResult();
            databaseOjectResult.OK = await _brandHelper.CheckPermissionToDelete(ID);
            return Ok(databaseOjectResult);
        }
        [HttpDelete]
        [Route("softDeleteBrand")]
        public async Task<IActionResult> SoftDeleteBrandByID(string ID)
        {
            if (ID == null)
            {
                return BadRequest();
            }
            await _brandHelper.SoftDeleteBrandByID(ID);

            return Ok();
        }
        [HttpPatch]
        [Route("restoreBrand")]
        public async Task<IActionResult> RestoreBrandByID(string ID)
        {
            if (ID == null)
            {
                return BadRequest();
            }
            await _brandHelper.RestoreBrandByID(ID);

            return Ok();
        }
    }
}
