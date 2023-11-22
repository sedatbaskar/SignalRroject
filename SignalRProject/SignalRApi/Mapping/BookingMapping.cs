using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalREntityLayer.Entities;

namespace SignalR.Api.Mapping
{
    public class BookingMapping:Profile
    {

        public BookingMapping()
        {
            CreateMap<Booking,CreateBookingDto>().ReverseMap();
            CreateMap<Booking,UpdateBookingDto>().ReverseMap();
            CreateMap<Booking,GetBookingDto>().ReverseMap();
            CreateMap<Booking,GetBookingDto>().ReverseMap();
        }
    }
}
