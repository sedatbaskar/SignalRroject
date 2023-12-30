using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.SocialMedia;
using SignalR.DtoLayer.TestimonialDto;
using SignalREntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService socialMediaService;
        private readonly IMapper mapper;

        public SocialMediaController(ISocialMediaService socialMediaService, IMapper mapper)
        {
            this.socialMediaService = socialMediaService;
            this.mapper = mapper;
        }

        [HttpGet]

        public IActionResult SocialMediaList()
        {
            var value = mapper.Map<List<ResultSocialMediaDto>>(socialMediaService.TGetListAll());

            return Ok(value);

        }

        [HttpPost]

        public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            socialMediaService.TAdd(new SocialMedia()
            {
                Icon = createSocialMediaDto.Icon,
                Title = createSocialMediaDto.Title,
                Url = createSocialMediaDto.Url,


            });

            return Ok("Social Media bilgisi Eklendi");
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteSocialMedia(int id)
        {
            var value = socialMediaService.TGetById(id);
            socialMediaService.TDelete(value);
            return Ok("Social Media Bilgisi Silindi");
        }

        [HttpGet("{id}")]

        public IActionResult GetSocialMedia(int id)
        {
            var value = socialMediaService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]

        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            socialMediaService.TUpdate(new SocialMedia()
            {

                Icon = updateSocialMediaDto.Icon,
                Title = updateSocialMediaDto.Title,
                Url = updateSocialMediaDto.Url,
                SocialMediaID = updateSocialMediaDto.SocialMediaID


            });
            return Ok("Social Media bilgisi güncellendi");

        }


    }
}

