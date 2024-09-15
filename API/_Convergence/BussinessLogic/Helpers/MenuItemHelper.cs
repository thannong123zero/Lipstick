using API._Convergence.DataAccess.ContextObject;
using AutoMapper;
using SharedLibrary.DTO;
using SharedLibrary.UserInterfaceDTO;

namespace API._Convergence.BussinessLogic.Helpers
{
    public class MenuItemHelper
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public MenuItemHelper(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;

        }
        public async Task<IEnumerable<MenuItemUI>> GetMenuItems(string menuGroupID)
        {
            var listMenuItem = await _unitOfWork.MenuItemRepository.GetAllAsync();
            if (!string.IsNullOrEmpty(menuGroupID) && Guid.TryParse(menuGroupID, out Guid ID))
            {
                listMenuItem = listMenuItem.Where(s => s.MenuGroupID.ToString() == menuGroupID).ToList();
            }
            if (listMenuItem == null)
            {
                return null;
            }
            listMenuItem = listMenuItem.OrderBy(s => s.Priority).ThenByDescending(s => s.ModifiedOn).ToList();
            IEnumerable<MenuItemUI> listMenuItemUI = new List<MenuItemUI>();
            listMenuItemUI = _mapper.Map<IEnumerable<MenuItemUI>>(listMenuItem);

            return listMenuItemUI;
        }
        public async Task<MenuItemUI> GetMenuItemByID(string ID)
        {
            if (!Guid.TryParse(ID, out var id))
            {
                return null;
            }
            var menuItem = await _unitOfWork.MenuItemRepository.GetByIdAsync(Guid.Parse(ID));
            MenuItemUI menuItemUI = _mapper.Map<MenuItemUI>(menuItem);
            return menuItemUI;
        }
        public async Task AddMenuItem(MenuItemUI model)
        {
            try
            {
                MenuItem entity = _mapper.Map<MenuItem>(model);
                entity.ID = Guid.NewGuid();
                await _unitOfWork.MenuItemRepository.CreateAsync(entity);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task UpdateMenuItem(MenuItemUI model)
        {
            try
            {
                MenuItem menuItem = await _unitOfWork.MenuItemRepository.GetByIdAsync(model.ID);
                if (menuItem == null)
                {
                    return;
                }
                menuItem.MenuGroupID = model.MenuGroupID;
                menuItem.NameEN = model.NameEN;
                menuItem.NameVN = model.NameVN;
                menuItem.DescriptionEN = model.DescriptionEN;
                menuItem.DescriptionVN = model.DescriptionVN;
                menuItem.ModifiedOn = DateTime.Now;
                menuItem.Priority = model.Priority;
                menuItem.IsActive = model.IsActive;
                menuItem.IsDeleted = model.IsDeleted;
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<bool> DeleteMenuItemByID(string ID)
        {
            MenuItem menuItem = await _unitOfWork.MenuItemRepository.GetByIdAsync(Guid.Parse(ID));

            if (menuItem != null && menuItem.Products.Count <= 0)
            {
                await _unitOfWork.MenuItemRepository.DeleteAsync(Guid.Parse(ID));
                await _unitOfWork.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task SoftDeleteMenuItemByID(string ID)
        {
            var menuItem = await _unitOfWork.MenuItemRepository.GetByIdAsync(Guid.Parse(ID));
            if (menuItem != null)
            {
                menuItem.IsDeleted = true;
                menuItem.ModifiedOn = DateTime.Now;
                //await _unitOfWork.MenuItemRepository.Update(menuItem);
                await _unitOfWork.SaveChangesAsync();
            }
        }
        public async Task<bool> RestoreMenuItemByID(string ID)
        {
            var menuItem = await _unitOfWork.MenuItemRepository.GetByIdAsync(Guid.Parse(ID));
            if (menuItem != null && menuItem.Products.Count <= 0)
            {
                menuItem.IsDeleted = false;
                menuItem.ModifiedOn = DateTime.Now;
                //await _unitOfWork.MenuItemRepository.Update(menuItem);
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
            MenuItem menuItem = await _unitOfWork.MenuItemRepository.GetByIdAsync(Guid.Parse(ID));

            if (menuItem != null && menuItem.Products.Count <= 0)
            {
                return true;
            }
            return false;
        }
    }
}
