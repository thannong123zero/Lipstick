using AutoMapper;
using SharedLibrary.DTO;
using SharedLibrary.UserInterfaceDTO;

namespace API.Services
{
    public class AutoMapperAPI : Profile
    {
        public AutoMapperAPI()
        {
            CreateMap<MenuGroup,MenuGroupUI>().ReverseMap();
            CreateMap<MenuItem,MenuItemUI>().ReverseMap();
            CreateMap<Unit,UnitUI>().ReverseMap();
            CreateMap<Topic,TopicUI>().ReverseMap();
            CreateMap<Brand,BrandUI>().ReverseMap();
            CreateMap<Article, ArticleUI>().ReverseMap();
            CreateMap<Product, ProductUI>().ReverseMap();
        }
    }
}
