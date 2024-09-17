using API._Convergence.DataAccess.ContextObject;
using AutoMapper;
using SharedLibrary.DTO;
using SharedLibrary.UserInterfaceDTO;

namespace API._Convergence.BussinessLogic.Helpers
{
    public class BrandHelper
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public BrandHelper(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;

        }
        public async Task<IEnumerable<BrandUI>> GetBrands()
        {
            var listBrand = await _unitOfWork.BrandRepository.GetAllAsync();
            if (listBrand == null)
            {
                return null;
            }
            listBrand = listBrand.OrderBy(s => s.ModifiedOn);
            IEnumerable<BrandUI> listBrandUI = new List<BrandUI>();
            listBrandUI = _mapper.Map<IEnumerable<BrandUI>>(listBrand);

            return listBrandUI;
        }
        public async Task<BrandUI> GetBrandByID(string ID)
        {
            if (!Guid.TryParse(ID, out var id))
            {
                return null;
            }
            var brand = await _unitOfWork.BrandRepository.GetByIdAsync(Guid.Parse(ID));
            BrandUI brandUI = _mapper.Map<BrandUI>(brand);
            return brandUI;
        }
        public async Task AddBrand(BrandUI model)
        {
            try
            {
                Brand entity = _mapper.Map<Brand>(model);
                entity.ID = Guid.NewGuid();
                await _unitOfWork.BrandRepository.CreateAsync(entity);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task UpdateBrand(BrandUI model)
        {
            try
            {
                Brand brand = await _unitOfWork.BrandRepository.GetByIdAsync(model.ID);
                if (brand == null)
                {
                    return;
                }
                brand.NameEN = model.NameEN;
                brand.NameVN = model.NameVN;
                brand.DescriptionEN = model.DescriptionEN;
                brand.DescriptionVN = model.DescriptionVN;
                brand.ModifiedOn = DateTime.Now;
                brand.IsActive = model.IsActive;
                brand.IsDeleted = model.IsDeleted;
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<bool> DeleteBrandByID(string ID)
        {
            Brand brand = await _unitOfWork.BrandRepository.GetByIdAsync(Guid.Parse(ID));

            if (brand != null && brand.Products.Count <= 0)
            {
                await _unitOfWork.BrandRepository.DeleteAsync(Guid.Parse(ID));
                await _unitOfWork.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> SoftDeleteBrandByID(string ID)
        {
            var brand = await _unitOfWork.BrandRepository.GetByIdAsync(Guid.Parse(ID));
            if (brand != null && brand.Products.Count <= 0)
            {
                brand.IsDeleted = true;
                brand.ModifiedOn = DateTime.Now;
                //await _unitOfWork.BrandRepository.Update(brand);
                await _unitOfWork.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> CheckPermissionToDelete(string ID)
        {
            if (!Guid.TryParse(ID, out var id))
            {
                return false;
            }
            Brand brand = await _unitOfWork.BrandRepository.GetByIdAsync(Guid.Parse(ID));

            if (brand != null && brand.Products.Count <= 0)
            {
                return true;
            }
            return false;
        }
        public async Task RestoreBrandByID(string ID)
        {
            var brand = await _unitOfWork.BrandRepository.GetByIdAsync(Guid.Parse(ID));
            if (brand != null)
            {
                brand.IsDeleted = false;
                brand.ModifiedOn = DateTime.Now;
                await _unitOfWork.SaveChangesAsync();
            }
        }
    }
}
