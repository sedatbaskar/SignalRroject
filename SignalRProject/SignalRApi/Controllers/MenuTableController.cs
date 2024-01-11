﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.MenuTableDto;
using SignalR.EntityLayer.Entities;
using SignalREntityLayer.Entities;

namespace SignalR.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MenuTableController : ControllerBase
	{
		private readonly IMenuTableService _menuTableService;

		public MenuTableController(IMenuTableService menuTableService)
		{
			_menuTableService = menuTableService;
		}


		[HttpGet("MenuTableCount")]

		public IActionResult MenuTableCount()
		{

			return Ok(_menuTableService.TMenuTableCount());

		}


		[HttpGet]

		public IActionResult MenuTableList()
		{
			var values = _menuTableService.TGetListAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult CreateMenuTable(CreateMenuTableDto createMenuTableDto)
		{
			MenuTable menuTable = new MenuTable()
			{
				Name = createMenuTableDto.Name,
				Status = false


			};

			_menuTableService.TAdd(menuTable);
			return Ok("Masa Bşarılı Bir Şekilde Eklendi");
		}
		[HttpDelete("{id}")]

		public IActionResult DeleteMenuTable(int id)
		{
			var values = _menuTableService.TGetById(id);
			_menuTableService.TDelete(values);
			return Ok("Masa başarılı bir şekilde silindi");





		}

		[HttpPut]
		public IActionResult UpdateMenuTable(UpdateMenuTableDto  updateMenuTableDto)
		{
			MenuTable menuTable = new MenuTable()
			{
				Name = updateMenuTableDto.Name,
				MenuTableID = updateMenuTableDto.MenuTableID,
				Status = false
				
			};
			_menuTableService.TUpdate(menuTable);
			return Ok("Menutable Alanı Güncellendi");
		}

		[HttpGet("{id}")]

		public IActionResult GetMenuTable(int id)
		{
			var values = _menuTableService.TGetById(id);
			return Ok(values);
		}

	}
}
