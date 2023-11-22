using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalREntityLayer.Entities;

namespace SignalR.Api.Mapping
{
    public class DiscountMapping : Profile
    {
        public DiscountMapping()
        {

            CreateMap<Discount, CreateBookingDto>().ReverseMap();
            CreateMap<Discount, UpdateBookingDto>().ReverseMap();
            CreateMap<Discount, GetBookingDto>().ReverseMap();
            CreateMap<Discount, ResultBookingDto>().ReverseMap();
        }
    }
}
