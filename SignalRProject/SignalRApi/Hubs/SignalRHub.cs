﻿using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalR.BusinessLayer.UnitOfWork.Abstract;
using SignalR.BusinessLayer.UnitOfWork.Concrete;
using SignalR.DataAccessLayer.Concrete;

namespace SignalR.Api.Hubs
{
    public class SignalRHub : Hub
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly IMoneyCasesService _moneyCasesService;
        private readonly IMenuTableService _menuTableService;
        public SignalRHub(ICategoryService categoryService, IProductService productService, IOrderService orderService,IMoneyCasesService moneyCasesService,IMenuTableService menuTableService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _orderService = orderService;   
            _moneyCasesService = moneyCasesService;
            _menuTableService = menuTableService;

        }

        public async Task SendStatistic()
        {
            var value = _categoryService.TCategoryCount();
            await Clients.All.SendAsync("ReceiveCategoryCount", value);

            var value2 = _productService.TProductCount();
            await Clients.All.SendAsync("ReceiveProductCount", value2);

            var value3 = _categoryService.TActiveCategoryCount();
            await Clients.All.SendAsync("ReceiveActiveCategoryCount", value3);

            var value4 = _categoryService.TPassiveCategoryCount();
            await Clients.All.SendAsync("ReceivePassiveCategoryCount", value4);

            var value5 = _productService.TProductCountbyCategoryNameHamburger();
            await Clients.All.SendAsync("ReceiveProductCountbyCategoryNameHamburger", value5);

            var value6 = _productService.TProductCountbyCategoryNameDrink();
            await Clients.All.SendAsync("ReceiveProductCountbyCategoryNameDrink", value6);

            var value7 = _productService.TProductAvg();
            await Clients.All.SendAsync("ReceiveProductAvg", value7);

            var value8 = _productService.TProductNamePriceByMax();
            await Clients.All.SendAsync("ReceiveProductNamePriceByMax", value8);

            var value9 = _productService.TProductNamePriceByMin();
            await Clients.All.SendAsync("ReceiveProductNamePriceByMin", value9);

            var value10 = _productService.TProductAvgPriceByHamburger();
            await Clients.All.SendAsync("ReceiveProductAvgPriceByHamburger", value10.ToString("0.00"+ "₺"));

            var value11 = _orderService.TTotalOrderCount();
            await Clients.All.SendAsync("ReceiveTotalOrderCount", value11);

            var value12 = _orderService.TActiveOrderCount();
            await Clients.All.SendAsync("ReceiveActiveOrderCount", value12);

            var value13 = _orderService.TLastOrderPrice();
            await Clients.All.SendAsync("ReceiveLastOrderPrice", value13.ToString("0.00" + "₺"));

            var value14 = _moneyCasesService.TTotalMoneyCaseAmount();
            await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", value14.ToString("0.00" + "₺"));

            var value16 = _menuTableService.TMenuTableCount();
            await Clients.All.SendAsync("ReceiveMenuTableCount",value16);
        }
    }
}
