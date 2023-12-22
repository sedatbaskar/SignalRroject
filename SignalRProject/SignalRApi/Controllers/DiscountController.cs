using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.ContactDto;
using SignalR.DtoLayer.DiscountDto;
using SignalREntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {

        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;

       public DiscountController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult DiscountList()
        {
            var value = _mapper.Map<List<ResultDiscountDto>>(_discountService.TGetListAll);

            return Ok(value);

        }

        [HttpPost]

        public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
        {
            _discountService.TAdd(new Discount()
            {
               Title = createDiscountDto.Title,
                Amount = createDiscountDto.Amount,  
                 Description = createDiscountDto.Description,   
                 ImageUrl = createDiscountDto.ImageUrl,
            });

            return Ok("indirimde ki ürünler Eklendi");
        }

        [HttpDelete]

        public IActionResult DeleteDiscount(int id)
        {
            var value = _discountService.TGetById(id);
            _discountService.TDelete(value);
            return Ok("İndirimde ki ürünler Silindi");
        }

        [HttpGet("GetDiscount")]

        public IActionResult GetDiscount(int id)
        {
            var value = _discountService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]

        public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto )
        {
             _discountService.TUpdate(new Discount()
            {
               Title = updateDiscountDto.Title,
                Amount = updateDiscountDto.Amount,  
                 Description = updateDiscountDto.Description,   
                 ImageUrl = updateDiscountDto.ImageUrl,
                  DiscountID = updateDiscountDto.DiscountID,
            });
            return Ok("İndirimde ki ürünler Güncellendi");

        }
    }
}
