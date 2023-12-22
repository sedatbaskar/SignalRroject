using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.DiscountDto;
using SignalR.DtoLayer.FeatureDto;
using SignalREntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService featureService;
        private readonly IMapper mapper;

        public FeatureController(IFeatureService featureService, IMapper mapper)
        {
            this.featureService = featureService;
            this.mapper = mapper;
        }
        [HttpGet]

        public IActionResult FeatureList()
        {
            var value = mapper.Map<List<ResultDiscountDto>>(featureService.TGetListAll);

            return Ok(value);

        }

        [HttpPost]

        public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
        {
            featureService.TAdd(new Feature()
            {
                Title1 = createFeatureDto.Title1,
                Description1 = createFeatureDto.Description1,
                Description2 = createFeatureDto.Description2,
                Description3 = createFeatureDto.Description3,
                Title2 = createFeatureDto.Title2,
                Title3 = createFeatureDto.Title3,

            });

            return Ok("Öne çıkanlar  Eklendi");
        }

        [HttpDelete]

        public IActionResult DeleteFeature(int id)
        {
            var value = featureService.TGetById(id);
            featureService.TDelete(value);
            return Ok("Önce Çıkan Silindi");
        }

        [HttpGet("GetFeature")]

        public IActionResult GetFeature(int id)
        {
            var value = featureService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]

        public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            featureService.TUpdate(new Feature()
            {
                Title1 = updateFeatureDto.Title1,
                Description1 = updateFeatureDto.Description1,
                Description2 = updateFeatureDto.Description2,
                Description3 = updateFeatureDto.Description3,
                Title2 = updateFeatureDto.Title2,
                Title3 = updateFeatureDto.Title3,
                FeatureID = updateFeatureDto.FeatureID,



            });
            return Ok("Önce çıkanalr Güncellendi");

        }



    }
}
