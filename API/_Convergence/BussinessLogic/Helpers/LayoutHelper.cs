using API._Convergence.DataAccess.ContextObject;
using SharedLibrary.UserInterfaceDTO;

namespace API._Convergence.BussinessLogic.Helpers
{
    public class LayoutHelper
    {
        private readonly IUnitOfWork _unitOfWork;
        public LayoutHelper(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        //public async Task<LayoutUI> GetLayout(string language)
        //{

        //}
    }
}
