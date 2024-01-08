using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR.Api.Models;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DtoLayer.BasketDto;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {

        private readonly IBasketService _basketService;

        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [HttpGet]
        public IActionResult GetBasketByMenuTableID(int id)
        {
            var values = _basketService.TGetBasketByMenuTableNumber(id);
            return Ok(values);
        }

        [HttpGet("BasketListByMenuTableWithProductName")]
        public IActionResult BasketListByMenuTableWithProductName(int id)
        {
            using var context = new SignalRContext();

            var values = context.Baskets.Include(x => x.Product).Where
                (y => y.MenuTableID == id).Select(z => new ResultBasketListWithProduct
                {
                    BasketID = z.BasketID,
                    Count = z.Count,
                    MenuTableID = id,
                    Price = z.Price,
                    ProductID = z.ProductID,
                    ProductName = z.Product.ProductName,
                    TotalPrice = z.TotalPrice,

                }).ToList();

            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBasket(CreateBasketDto createBasketDto)
        {
            using var context = new SignalRContext();
            _basketService.TAdd(new Basket()
            {
                ProductID = createBasketDto.ProductID,
                Count = 1,
                MenuTableID = 4,
                Price = context.Product.Where(x => x.ProductID == createBasketDto.ProductID).Select
                (y => y.Price).FirstOrDefault(),
                TotalPrice = 0,


            });
            return Ok();

                }
    }

}
