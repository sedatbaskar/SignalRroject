using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalREntityLayer.Entities;

namespace SignalR.Api.Mapping
{
    public class FeatureMapping : Profile
    {

        public FeatureMapping()
        {

            CreateMap<Feature, CreateBookingDto>().ReverseMap();
            CreateMap<Feature, UpdateBookingDto>().ReverseMap();
            CreateMap<Feature, ResultBookingDto>().ReverseMap();
            CreateMap<Feature, GetBookingDto>().ReverseMap();

        }

    }
}
