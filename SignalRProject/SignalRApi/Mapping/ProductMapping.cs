using AutoMapper;
using SignalR.DtoLayer.ProductDto;
using SignalREntityLayer.Entities;

namespace SignalR.Api.Mapping
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {

            CreateMap<Product, GetProductDto>().ReverseMap();
            CreateMap<Product, CreateProdcutDto>().ReverseMap();
            CreateMap<Product, GetProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, ResultProductWithCategory>().ReverseMap();

            CreateMap<Product, ResultProductWithCategory>()
                .ForMember(destinationMember: a => a.CategoryName, memberOptions: p => p.MapFrom(c => c.Category.CategoryName))
                .ReverseMap();



        }
    }
}
