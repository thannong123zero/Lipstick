using API.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.UserInterfaceDTO;

namespace API.Controllers
{
    [Route("api/Unit")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        private readonly UnitHelper _unitHelper;
        public UnitController(UnitHelper unitHelper)
        {
            _unitHelper = unitHelper;
        }
        [HttpGet]
        [Route("getUnits")]
        public async Task<IActionResult> GetUnits()
        {
            IEnumerable<UnitUI> data = await _unitHelper.GetUnits();
            if (data == null)
            {
                return BadRequest();
            }
            await _unitHelper.GetUnits();
            return Ok(data);
        }
        [HttpGet]
        [Route("getUnitByID")]
        public async Task<IActionResult> GetUnitByID(string ID)
        {
            UnitUI data = await _unitHelper.GetUnitByID(ID);
            if (data == null)
            {
                return BadRequest();
            }
            return Ok(data);
        }
        [HttpPost]
        [Route("addUnit")]
        public async Task<IActionResult> AddUnit([FromBody] UnitUI model)
        {
            if (model == null)
            {
                return BadRequest();
            }
            await _unitHelper.AddUnit(model);
            return Ok();
        }
        [HttpPut]
        [Route("updateUnit")]
        public async Task<IActionResult> UpdateUnit([FromBody] UnitUI model)
        {
            if (model == null)
            {
                return BadRequest();
            }
            await _unitHelper.UpdateUnit(model);

            return Ok();
        }
        [HttpDelete]
        [Route("deleteUnit")]
        public async Task<IActionResult> DeleteUnitByID(string ID)
        {
            if (ID == null)
            {
                return BadRequest();
            }
            await _unitHelper.DeleteUnitByID(ID);
            return Ok();
        }
        [HttpGet]
        [Route("checkPermissionToDelete")]
        public async Task<IActionResult> CheckPermissionToDelete(string ID)
        {
            DatabaseOjectResult databaseOjectResult = new DatabaseOjectResult();
            databaseOjectResult.OK = await _unitHelper.CheckPermissionToDelete(ID);
            return Ok(databaseOjectResult);
        }
        [HttpDelete]
        [Route("softDeleteUnit")]
        public async Task<IActionResult> SoftDeleteUnitByID(string ID)
        {
            if (ID == null)
            {
                return BadRequest();
            }
            await _unitHelper.SoftDeleteUnitByID(ID);

            return Ok();
        }
        [HttpPatch]
        [Route("restoreUnit")]
        public async Task<IActionResult> RestoreUnitByID(string ID)
        {
            if (ID == null)
            {
                return BadRequest();
            }
            await _unitHelper.RestoreUnitByID(ID);

            return Ok();
        }
    }
}
