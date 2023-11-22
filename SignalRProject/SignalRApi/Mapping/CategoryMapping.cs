using AutoMapper;
using SignalR.DtoLayer.CategoryDto;
using SignalREntityLayer.Entities;

namespace SignalR.Api.Mapping
{
    public class CategoryMapping : Profile
    {

        public CategoryMapping()
        {
            CreateMap<Category, ResultCategoryDto>().ReverseMap();  
            CreateMap<Category, GetCategoryDto>().ReverseMap();  
            CreateMap<Category, CreateCategoryDto>().ReverseMap();  
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();  

        }
    }
}
