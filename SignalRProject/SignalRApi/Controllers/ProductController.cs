using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.DiscountDto;
using SignalR.DtoLayer.FeatureDto;
using SignalR.DtoLayer.ProductDto;
using SignalREntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductService productService;
        private readonly IMapper mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            this.productService = productService;
            this.mapper = mapper;
        }

        [HttpGet]

        public IActionResult ProductList()
        {
            var value = mapper.Map<List<ResultProductDto>>(productService.TGetListAll);

            return Ok(value);

        }




        [HttpGet("ProductListWithCategory")]


        public IActionResult ProductListWithCategory()


        {

            var value = mapper.Map<List<ResultProductWithCategory>>(productService.TGetProductsWithCategories());
            return Ok(value);   
        }



        [HttpPost]

        public IActionResult CreateProduct(CreateProdcutDto createProdcutDto)
        {
            productService.TAdd(new Product()
            {
                Description = createProdcutDto.Description,
                ImageUrl = createProdcutDto.ImageUrl,
                Price = createProdcutDto.Price,
                ProductName = createProdcutDto.ProductName,
                ProductStatus = createProdcutDto.ProductStatus,



            });

            return Ok("Ürün Bilgisi Eklendi");
        }

        [HttpDelete]

        public IActionResult DeleteProduct(int id)
        {
            var value = productService.TGetById(id);
            productService.TDelete(value);
            return Ok("Ürün bilgisi Silindi");
        }

        [HttpGet("GetProduct")]

        public IActionResult GetProduct(int id)
        {
            var value = productService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]

        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            productService.TUpdate(new Product()
            {
                Description = updateProductDto.Description,
                ImageUrl = updateProductDto.ImageUrl,
                Price = updateProductDto.Price,
                ProductName = updateProductDto.ProductName,
                ProductStatus = updateProductDto.ProductStatus,
                ProductID = updateProductDto.ProductID,



            });
            return Ok("Ürünler güncellendi");

        }

    }
}
