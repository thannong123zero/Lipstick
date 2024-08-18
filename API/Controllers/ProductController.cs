using API.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.UserInterfaceDTO;

namespace API.Controllers
{
    [Route("api/Product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductHelper _productHelper;
        public ProductController(ProductHelper productHelper)
        {
            _productHelper = productHelper;
        }
        [HttpGet]
        [Route("getProducts")]
        public async Task<IActionResult> GetProducts()
        {
            IEnumerable<ProductUI> data = await _productHelper.GetProducts();
            if (data == null)
            {
                return BadRequest();
            }
            await _productHelper.GetProducts();
            return Ok(data);
        }
        [HttpGet]
        [Route("getProductByID")]
        public async Task<IActionResult> GetProductByID(string ID)
        {
            ProductUI data = await _productHelper.GetProductByID(ID);
            if (data == null)
            {
                return BadRequest();
            }
            return Ok(data);
        }
        [HttpPost]
        [Route("addProduct")]
        public async Task<IActionResult> AddProduct([FromBody] ProductUI model)
        {
            if (model == null)
            {
                return BadRequest();
            }
            await _productHelper.AddProduct(model);
            return Ok();
        }
        [HttpPut]
        [Route("updateProduct")]
        public async Task<IActionResult> UpdateProduct([FromBody] ProductUI model)
        {
            if (model == null)
            {
                return BadRequest();
            }
            await _productHelper.UpdateProduct(model);

            return Ok();
        }
        [HttpDelete]
        [Route("deleteProduct")]
        public async Task<IActionResult> DeleteProductByID(string ID)
        {
            if (ID == null)
            {
                return BadRequest();
            }
            await _productHelper.DeleteProductByID(ID);
            return Ok();
        }
        //[HttpGet]
        //[Route("checkPermissionToDelete")]
        //public async Task<IActionResult> CheckPermissionToDelete(string ID)
        //{
        //    DatabaseOjectResult databaseOjectResult = new DatabaseOjectResult();
        //    databaseOjectResult.OK = await _productHelper.CheckPermissionToDelete(ID);
        //    return Ok(databaseOjectResult);
        //}
        [HttpDelete]
        [Route("softDeleteProduct")]
        public async Task<IActionResult> SoftDeleteProductByID(string ID)
        {
            if (ID == null)
            {
                return BadRequest();
            }
            await _productHelper.SoftDeleteProductByID(ID);

            return Ok();
        }
        [HttpPatch]
        [Route("restoreProduct")]
        public async Task<IActionResult> RestoreProductByID(string ID)
        {
            if (ID == null)
            {
                return BadRequest();
            }
            await _productHelper.RestoreProductByID(ID);

            return Ok();
        }
    }
}
