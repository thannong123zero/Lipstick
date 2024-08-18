using API.ContextObject;
using API.IRepositories;
using API.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SharedLibrary.DTO;
using SharedLibrary.UserInterfaceDTO;
using System.Collections.Generic;

namespace API.Helpers
{
    public class MenuGroupHelper
    {
        private UnitOfWork _unitOfWork ;
        private IMapper _mapper;
        public MenuGroupHelper(IMapper mapper,UnitOfWork unitOfWork) {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        
        }
        public async Task<IEnumerable<MenuGroupUI>> GetMenuGroups()
        {
            var listMenuGroup =  await _unitOfWork.MenuGroupRepository.GetAll(s => !s.IsDeleted);
            if(listMenuGroup == null) 
            {
                return null;
            }
            listMenuGroup = listMenuGroup.OrderBy(s=> s.Priority).ThenByDescending(s=> s.ModifiedOn);
            IEnumerable <MenuGroupUI> listMenuGroupUI = new List<MenuGroupUI>();
            listMenuGroupUI = _mapper.Map<IEnumerable<MenuGroupUI>>(listMenuGroup);
         
            return listMenuGroupUI;
        }
        public async Task<MenuGroupUI> GetMenuGroupByID(string ID)
        {
            if(!Guid.TryParse(ID, out var id))
            {
                return null;
            }
            var menuGroup  = await _unitOfWork.MenuGroupRepository.GetById(Guid.Parse(ID));
            MenuGroupUI menuGroupUI = _mapper.Map<MenuGroupUI>(menuGroup);
            return menuGroupUI;
        }
        public async Task AddMenuGroup(MenuGroupUI model)
        {
            try
            {
                MenuGroup entity = _mapper.Map<MenuGroup>(model);
                entity.ID = Guid.NewGuid();
                await _unitOfWork.MenuGroupRepository.Create(entity);
                _unitOfWork.Save();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// We have a problem
        /// that is "We just need to update some permisstion field"
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task UpdateMenuGroup(MenuGroupUI model)
        {
            try
            {
                //MenuGroup newModel = _mapper.Map<MenuGroup>(model);

                MenuGroup menuGroup = await _unitOfWork.MenuGroupRepository.GetById(model.ID);
                if(menuGroup == null)
                {
                    return;
                }
                menuGroup.NameEN = model.NameEN;
                menuGroup.NameVN = model.NameVN;
                menuGroup.DescriptionEN = model.DescriptionEN;
                menuGroup.DescriptionVN = model.DescriptionVN;
                menuGroup.ModifiedOn = DateTime.Now;
                menuGroup.IsActive = model.IsActive;
                menuGroup.Priority = model.Priority;
                menuGroup.IsDeleted = model.IsDeleted;
                menuGroup.InNavbar = model.InNavbar;

                //await _unitOfWork.MenuGroupRepository.Update(newModel);
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<bool> DeleteMenuGroupByID(string ID)
        {
            MenuGroup menuGroup = await _unitOfWork.MenuGroupRepository.GetById(Guid.Parse(ID));

            if (menuGroup != null && menuGroup.MenuItems.Count <= 0)
            {
                await _unitOfWork.MenuGroupRepository.Delete(Guid.Parse(ID));
                _unitOfWork.Save();
                return true;
            }
            return false;
        }
        public async Task<bool> SoftDeleteMenuGroupByID(string ID)
        {
            var menuGroup = await _unitOfWork.MenuGroupRepository.GetById(Guid.Parse(ID));
            if(menuGroup != null && menuGroup.MenuItems.Count <= 0)
            {
                menuGroup.IsDeleted = true;
                menuGroup.ModifiedOn = DateTime.Now;
                //await _unitOfWork.MenuGroupRepository.Update(menuGroup);
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
            MenuGroup menuGroup = await _unitOfWork.MenuGroupRepository.GetById(Guid.Parse(ID));

            if (menuGroup != null && menuGroup.MenuItems.Count <= 0)
            {
                return true;
            }
            return false;
        }
        public async Task RestoreMenuGroupByID(string ID)
        {
            var menuGroup = await _unitOfWork.MenuGroupRepository.GetById(Guid.Parse(ID));
            if (menuGroup != null)
            {
                menuGroup.IsDeleted = false;
                menuGroup.ModifiedOn = DateTime.Now;
                //await _unitOfWork.MenuGroupRepository.Update(menuGroup);
                _unitOfWork.Save();
            }
        }
    }
}
