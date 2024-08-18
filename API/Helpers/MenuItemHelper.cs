using API.Repositories;
using AutoMapper;
using SharedLibrary.DTO;
using SharedLibrary.UserInterfaceDTO;

namespace API.Helpers
{
    public class MenuItemHelper
    {
        private UnitOfWork _unitOfWork;
        private IMapper _mapper;
        public MenuItemHelper(IMapper mapper, UnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;

        }
        public async Task<IEnumerable<MenuItemUI>> GetMenuItems(string menuGroupID)
        {
            var listMenuItem = await _unitOfWork.MenuItemRepository.GetAll();
            if (!string.IsNullOrEmpty(menuGroupID) && Guid.TryParse(menuGroupID,out Guid ID))
            {
                listMenuItem = listMenuItem.Where(s => s.MenuGroupID.ToString()==menuGroupID).ToList();
            }
            if(listMenuItem == null)
            {
                return null;
            }
            listMenuItem = listMenuItem.OrderBy(s => s.Priority).ThenByDescending(s=>s.ModifiedOn).ToList();
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
            var menuItem = await _unitOfWork.MenuItemRepository.GetById(Guid.Parse(ID));
            MenuItemUI menuItemUI = _mapper.Map<MenuItemUI>(menuItem);
            return menuItemUI;
        }
        public async Task AddMenuItem(MenuItemUI model)
        {
            try
            {
                MenuItem entity = _mapper.Map<MenuItem>(model);
                entity.ID = Guid.NewGuid();
                await _unitOfWork.MenuItemRepository.Create(entity);
                _unitOfWork.Save();
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
                MenuItem menuItem = await _unitOfWork.MenuItemRepository.GetById(model.ID);
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
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<bool> DeleteMenuItemByID(string ID)
        {
            MenuItem menuItem = await _unitOfWork.MenuItemRepository.GetById(Guid.Parse(ID));

            if (menuItem != null && menuItem.Products.Count <= 0)
            {
                await _unitOfWork.MenuItemRepository.Delete(Guid.Parse(ID));
                _unitOfWork.Save();
                return true;
            }
            return false;
        }
        public async Task SoftDeleteMenuItemByID(string ID)
        {
            var menuItem = await _unitOfWork.MenuItemRepository.GetById(Guid.Parse(ID));
            if (menuItem != null)
            {
                menuItem.IsDeleted = true;
                menuItem.ModifiedOn = DateTime.Now;
                //await _unitOfWork.MenuItemRepository.Update(menuItem);
                _unitOfWork.Save();
            }
        }
        public async Task<bool> RestoreMenuItemByID(string ID)
        {
            var menuItem = await _unitOfWork.MenuItemRepository.GetById(Guid.Parse(ID));
            if (menuItem != null && menuItem.Products.Count <= 0)
            {
                menuItem.IsDeleted = false;
                menuItem.ModifiedOn = DateTime.Now;
                //await _unitOfWork.MenuItemRepository.Update(menuItem);
                _unitOfWork.Save();
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
            MenuItem menuItem = await _unitOfWork.MenuItemRepository.GetById(Guid.Parse(ID));

            if (menuItem != null && menuItem.Products.Count <= 0)
            {
                return true;
            }
            return false;
        }
    }
}
