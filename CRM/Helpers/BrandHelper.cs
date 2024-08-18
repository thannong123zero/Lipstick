using CRM.Services.APIServices;
using SharedLibrary.UserInterfaceDTO;

namespace CRM.Helpers
{
    public class BrandHelper
    {
        private readonly BrandAPIService _APIService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public BrandHelper(BrandAPIService aPIService, IWebHostEnvironment webHostEnvironment)
        {
            _APIService = aPIService;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IEnumerable<BrandUI>> GetBrands()
        {
            return await _APIService.GetBrands();
        }
        public async Task<BrandUI> GetBrandByID(string ID)
        {
            return await _APIService.GetBrandByID(ID);
        }
        public async Task CreateBrand(BrandUI model)
        {
            if (model.UploadImage != null)
            {
                string path = Path.Combine(_webHostEnvironment.WebRootPath, "BrandImages");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                model.Avatar = string.Concat(Guid.NewGuid(), ".png");
                string filePath = Path.Combine(path, model.Avatar);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await model.UploadImage.CopyToAsync(fileStream);
                }
            }

            await _APIService.CreateBrand(model);
        }
        public async Task UpdateBrand(BrandUI model)
        {
            await _APIService.UpdateBrand(model);
        }
        public async Task<bool> SoftDelete(string ID)
        {
            return await _APIService.SoftDelete(ID);
        }
    }
}
