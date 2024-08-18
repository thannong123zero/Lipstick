using CRM.Services.APIServices;
using SharedLibrary.UserInterfaceDTO;

namespace CRM.Helpers
{
    public class ProductHelper
    {
        private readonly ProductAPIService _APIService;
        public ProductHelper(ProductAPIService aPIService)
        {
            _APIService = aPIService;
        }

        public async Task<IEnumerable<ProductUI>> GetProducts()
        {
            return await _APIService.GetProducts();
        }
        public async Task<ProductUI> GetProductByID(string ID)
        {
            return await _APIService.GetProductByID(ID);
        }
        public async Task CreateProduct(ProductUI model)
        {
            await _APIService.CreateProduct(model);
        }
        public async Task UpdateProduct(ProductUI model)
        {
            await _APIService.UpdateProduct(model);
        }
        public async Task<bool> SoftDelete(string ID)
        {
            return await _APIService.SoftDelete(ID);
        }
    }
}
