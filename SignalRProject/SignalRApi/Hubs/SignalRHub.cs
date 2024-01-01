﻿using Microsoft.AspNetCore.SignalR;
using SignalR.DataAccessLayer.Concrete;

namespace SignalR.Api.Hubs
{
    public class SignalRHub : Hub
    {
        SignalRContext context=new SignalRContext();

        public async Task SendCategoryCount()
        {

            var value=context.Categorys.Count();
            await Clients.All.SendAsync("ReceiveCategoryCount", value);

        }

        
    }
}