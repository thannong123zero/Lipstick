using API.Repositories;
using SharedLibrary.UserInterfaceDTO;

namespace API.Helpers
{
    public class LayoutHelper
    {
        private readonly UnitOfWork _unitOfWork;
        public LayoutHelper(UnitOfWork unitOfWork)
        {
              _unitOfWork = unitOfWork;
        }
        //public async Task<LayoutUI> GetLayout(string language)
        //{

        //}
    }
}
