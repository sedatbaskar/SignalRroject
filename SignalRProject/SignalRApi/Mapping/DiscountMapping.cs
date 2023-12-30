using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.DiscountDto;
using SignalREntityLayer.Entities;

namespace SignalR.Api.Mapping
{
    public class DiscountMapping : Profile
    {
        public DiscountMapping()
        {

            CreateMap<Discount, CreateDiscountDto>().ReverseMap();
            CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
            CreateMap<Discount, GetDiscountDto>().ReverseMap();
            CreateMap<Discount, ResultDiscountDto>().ReverseMap();
        }
    }
}
