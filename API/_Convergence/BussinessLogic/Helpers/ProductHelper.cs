using API._Convergence.DataAccess.ContextObject;
using AutoMapper;
using SharedLibrary.DTO;
using SharedLibrary.UserInterfaceDTO;

namespace API._Convergence.BussinessLogic.Helpers
{
    public class ProductHelper
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public ProductHelper(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;

        }
        public async Task<IEnumerable<ProductUI>> GetProducts()
        {
            var listProduct = await _unitOfWork.ProductRepository.GetAllAsync();
            if (listProduct == null)
            {
                return null;
            }
            listProduct = listProduct.OrderBy(s => s.ModifiedOn);
            IEnumerable<ProductUI> listProductUI = new List<ProductUI>();
            listProductUI = _mapper.Map<IEnumerable<ProductUI>>(listProduct);

            return listProductUI;
        }
        public async Task<ProductUI> GetProductByID(string ID)
        {
            if (!Guid.TryParse(ID, out var id))
            {
                return null;
            }
            var product = await _unitOfWork.ProductRepository.GetByIdAsync(Guid.Parse(ID));
            ProductUI productUI = _mapper.Map<ProductUI>(product);
            return productUI;
        }
        public async Task AddProduct(ProductUI model)
        {
            try
            {
                Product entity = _mapper.Map<Product>(model);
                entity.ID = Guid.NewGuid();
                await _unitOfWork.ProductRepository.CreateAsync(entity);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task UpdateProduct(ProductUI model)
        {
            try
            {
                Product product = await _unitOfWork.ProductRepository.GetByIdAsync(model.ID);
                if (product == null)
                {
                    return;
                }
                product.NameEN = model.NameEN;
                product.NameVN = model.NameVN;
                product.DescriptionEN = model.DescriptionEN;
                product.DescriptionVN = model.DescriptionVN;
                product.ModifiedOn = DateTime.Now;
                product.IsActive = model.IsActive;
                product.IsDeleted = model.IsDeleted;
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<bool> DeleteProductByID(string ID)
        {
            Product product = await _unitOfWork.ProductRepository.GetByIdAsync(Guid.Parse(ID));

            if (product == null)
            {
                return false;
            }
            await _unitOfWork.ProductRepository.DeleteAsync(Guid.Parse(ID));
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
        public async Task<bool> SoftDeleteProductByID(string ID)
        {
            var product = await _unitOfWork.ProductRepository.GetByIdAsync(Guid.Parse(ID));
            if (product == null)
            {
                return false;
            }
            product.IsDeleted = true;
            product.ModifiedOn = DateTime.Now;
            await _unitOfWork.SaveChangesAsync();
            return true;

        }
        //public async Task<bool> CheckPermissionToDelete(string ID)
        //{
        //    if (!Guid.TryParse(ID, out var id))
        //    {
        //        return false;
        //    }
        //    Product product = await _unitOfWork.ProductRepository.GetById(Guid.Parse(ID));

        //    if (product != null && product.Products.Count <= 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        public async Task RestoreProductByID(string ID)
        {
            var product = await _unitOfWork.ProductRepository.GetByIdAsync(Guid.Parse(ID));
            if (product != null)
            {
                product.IsDeleted = false;
                product.ModifiedOn = DateTime.Now;
                await _unitOfWork.SaveChangesAsync();
            }
        }
    }
}
