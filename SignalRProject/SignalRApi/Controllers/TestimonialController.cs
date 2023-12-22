using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.ProductDto;
using SignalR.DtoLayer.TestimonialDto;
using SignalREntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService testimonialService;
        private readonly IMapper mapper;

        public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
        {
            this.testimonialService = testimonialService;
            this.mapper = mapper;
        }

        [HttpGet]

        public IActionResult TestimonialList()
        {
            var value = mapper.Map<List<ResultTestimonialDto>>(testimonialService.TGetListAll);

            return Ok(value);

        }

        [HttpPost]

        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            testimonialService.TAdd(new Testimonial()
            {
                Comment = createTestimonialDto.Comment,
                ImageUrl = createTestimonialDto.ImageUrl,
                Name = createTestimonialDto.Name,
                Status = createTestimonialDto.Status,
                Title = createTestimonialDto.Title



            });

            return Ok("Referans bilgisi Eklendi");
        }

        [HttpDelete]

        public IActionResult DeleteTestimonial(int id)
        {
            var value = testimonialService.TGetById(id);
            testimonialService.TDelete(value);
            return Ok("Referans bilgisi Silindi");
        }

        [HttpGet("GetTestimonial")]

        public IActionResult GetTestimonial(int id)
        {
            var value = testimonialService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]

        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            testimonialService.TUpdate(new Testimonial()
            {

                Comment = updateTestimonialDto.Comment,
                ImageUrl = updateTestimonialDto.ImageUrl,
                Name = updateTestimonialDto.Name,
                Status = updateTestimonialDto.Status,
                Title = updateTestimonialDto.Title,
                TestimonialID = updateTestimonialDto.TestimonialID


            });
            return Ok("Referans bilgisi güncellendi");

        }


    }
}
