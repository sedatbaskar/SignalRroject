using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.FeatureDto;
using SignalREntityLayer.Entities;

namespace SignalR.Api.Mapping
{
    public class FeatureMapping : Profile
    {

        public FeatureMapping()
        {

            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, GetFeatureDto>().ReverseMap();

        }

    }
}
