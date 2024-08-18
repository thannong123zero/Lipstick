using CRM.Services.APIServices;
using SharedLibrary.UserInterfaceDTO;

namespace CRM.Helpers
{
    public class UnitHelper
    {
        private readonly UnitAPIService _APIService;
        public UnitHelper(UnitAPIService aPIService)
        {
            _APIService = aPIService;
        }

        public async Task<IEnumerable<UnitUI>> GetUnits()
        {
            return await _APIService.GetUnits();
        }
        public async Task<UnitUI> GetUnitByID(string ID)
        {
            return await _APIService.GetUnitByID(ID);
        }
        public async Task CreateUnit(UnitUI model)
        {
            await _APIService.CreateUnit(model);
        }
        public async Task UpdateUnit(UnitUI model)
        {
            await _APIService.UpdateUnit(model);
        }
        public async Task<bool> SoftDelete(string ID)
        {
            return await _APIService.SoftDelete(ID);
        }
    }
}
