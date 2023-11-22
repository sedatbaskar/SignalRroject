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


        }
    }
}
