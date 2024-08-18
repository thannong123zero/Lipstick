using API.Repositories;
using AutoMapper;
using SharedLibrary.DTO;
using SharedLibrary.UserInterfaceDTO;

namespace API.Helpers
{
    public class UnitHelper
    {
        private UnitOfWork _unitOfWork;
        private IMapper _mapper;
        public UnitHelper(IMapper mapper, UnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;

        }
        public async Task<IEnumerable<UnitUI>> GetUnits()
        {
            var listUnit = await _unitOfWork.UnitRepository.GetAll();
            IEnumerable<UnitUI> listUnitUI = new List<UnitUI>();
            listUnitUI = _mapper.Map<IEnumerable<UnitUI>>(listUnit);

            return listUnitUI;
        }
        public async Task<UnitUI> GetUnitByID(string ID)
        {
            if (!Guid.TryParse(ID, out var id))
            {
                return null;
            }
            var unit = await _unitOfWork.UnitRepository.GetById(Guid.Parse(ID));
            UnitUI unitUI = _mapper.Map<UnitUI>(unit);
            return unitUI;
        }
        public async Task AddUnit(UnitUI model)
        {
            try
            {
                Unit entity = _mapper.Map<Unit>(model);
                entity.ID = Guid.NewGuid();
                await _unitOfWork.UnitRepository.Create(entity);
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task UpdateUnit(UnitUI model)
        {
            try
            {
                Unit unit = await _unitOfWork.UnitRepository.GetById(model.ID);
                if (unit == null)
                {
                    return;
                }
                unit.NameEN = model.NameEN;
                unit.NameVN = model.NameVN;
                unit.DescriptionEN = model.DescriptionEN;
                unit.DescriptionVN = model.DescriptionVN;
                unit.ModifiedOn = DateTime.Now;
                unit.IsActive = model.IsActive;
                unit.IsDeleted = model.IsDeleted;
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<bool> DeleteUnitByID(string ID)
        {
            Unit unit = await _unitOfWork.UnitRepository.GetById(Guid.Parse(ID));

            if (unit != null && unit.Products.Count <= 0)
            {
                await _unitOfWork.UnitRepository.Delete(Guid.Parse(ID));
                _unitOfWork.Save();
                return true;
            }
            return false;
        }
        public async Task SoftDeleteUnitByID(string ID)
        {
            var unit = await _unitOfWork.UnitRepository.GetById(Guid.Parse(ID));
            if (unit != null)
            {
                unit.IsDeleted = true;
                unit.ModifiedOn = DateTime.Now;
                //await _unitOfWork.UnitRepository.Update(unit);
                _unitOfWork.Save();
            }
        }
        public async Task<bool> RestoreUnitByID(string ID)
        {
            var unit = await _unitOfWork.UnitRepository.GetById(Guid.Parse(ID));
            if (unit != null && unit.Products.Count <= 0)
            {
                unit.IsDeleted = false;
                unit.ModifiedOn = DateTime.Now;
                //await _unitOfWork.UnitRepository.Update(unit);
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
            Unit unit = await _unitOfWork.UnitRepository.GetById(Guid.Parse(ID));

            if (unit != null && unit.Products.Count <= 0)
            {
                return true;
            }
            return false;
        }
    }
}
