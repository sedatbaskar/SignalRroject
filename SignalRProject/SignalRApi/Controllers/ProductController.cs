﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
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

		private readonly IProductService _productService;
		private readonly IMapper _mapper;

		public ProductController(IProductService productService, IMapper mapper)
		{
			_productService = productService;
			_mapper = mapper;
		}

		[HttpGet]

		public IActionResult ProductList()
		{
			var value = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());

			return Ok(value);

		}


		[HttpGet("ProductCount")]

		public IActionResult ProductCount()
		{
			return Ok(_productService.TProductCount());

		}

		[HttpGet("ProductAvg")]

		public IActionResult ProductAvg()
		{
			return Ok(_productService.TProductAvg());

		}

		[HttpGet("ProductNamePriceByMax")]

		public IActionResult ProductNamePriceByMax()
		{
			return Ok(_productService.TProductNamePriceByMax());

		}

		[HttpGet("ProductNamePriceByMin")]

		public IActionResult ProductNamePriceByMin()
		{
			return Ok(_productService.TProductNamePriceByMin());

		}

		[HttpGet("ProductCountbyCategoryNameHamburger")]

		public IActionResult ProductCountbyCategoryNameHamburger()
		{
			return Ok(_productService.TProductCountbyCategoryNameHamburger());
		}

		[HttpGet("ProductCountbyCategoryNameDrink")]

		public IActionResult ProductCountbyCategoryNameDrink()
		{
			return Ok(_productService.TProductCountbyCategoryNameDrink());
		}

        [HttpGet("ProductAvgPriceByHamburger")]

        public IActionResult ProductAvgPriceByHamburger()
        {
            return Ok(_productService.TProductAvgPriceByHamburger());
        }

        


        [HttpGet("ProductListWithCategory")]
		public IActionResult ProductListWithCategory()
		{
			var context = new SignalRContext();
			var values = context.Product.Include(x => x.Category).Select(y => new ResultProductWithCategory
			{
				Description = y.Description,
				ImageUrl = y.ImageUrl,
				Price = y.Price,
				ProductID = y.ProductID,
				ProductName = y.ProductName,
				ProductStatus = y.ProductStatus,
				CategoryName = y.Category.CategoryName
			});
			return Ok(values.ToList());
		}



		[HttpPost]

		public IActionResult CreateProduct(CreateProdcutDto createProdcutDto)
		{
			_productService.TAdd(new Product()
			{
				Description = createProdcutDto.Description,
				ImageUrl = createProdcutDto.ImageUrl,
				Price = createProdcutDto.Price,
				ProductName = createProdcutDto.ProductName,
				ProductStatus = createProdcutDto.ProductStatus,
				CategoryId = createProdcutDto.CategoryID


			});

			return Ok("Ürün Bilgisi Eklendi");
		}

		[HttpDelete("{id}")]

		public IActionResult DeleteProduct(int id)
		{
			var value = _productService.TGetById(id);
			_productService.TDelete(value);
			return Ok("Ürün bilgisi Silindi");
		}

		[HttpGet("{id}")]
		public IActionResult GetProduct(int id)
		{
			var value = _productService.TGetById(id);
			_productService.TUpdate(value);
			return Ok(value);
		}




		[HttpPut]

		public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
		{
			_productService.TUpdate(new Product()
			{
				Description = updateProductDto.Description,
				ImageUrl = updateProductDto.ImageUrl,
				Price = updateProductDto.Price,
				ProductName = updateProductDto.ProductName,
				ProductStatus = updateProductDto.ProductStatus,
				ProductID = updateProductDto.ProductID,
				CategoryId = updateProductDto.CategoryID


			});
			return Ok("Ürünler güncellendi");

		}

	}
}
