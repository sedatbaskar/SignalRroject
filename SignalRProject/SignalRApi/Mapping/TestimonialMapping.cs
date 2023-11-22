using AutoMapper;
using SignalR.DtoLayer.TestimonialDto;
using SignalREntityLayer.Entities;

namespace SignalR.Api.Mapping
{
    public class TestimonialMapping : Profile
    {
        public TestimonialMapping()
        {

            CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, GetTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();


        }
    }
}
