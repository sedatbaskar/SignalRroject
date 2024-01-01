﻿using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
	public class EfCategoryDal : GenericRepositories<Category>, ICategoryDal
	{
		public EfCategoryDal(SignalRContext context) : base(context)
		{
		}

		public int ActiveCategoryCount()
		{
			using var context = new SignalRContext();
			return context.Categorys.Where(x => x.Status == true).Count();
		}

		public int CategoryCount()
		{
			using var context = new SignalRContext();
			return context.Categorys.Count();
		}

		public int PassiveCategoryCount()
		{
			using var context= new SignalRContext();
			return context.Categorys.Where(x=>x.Status == false).Count();
		}
	}
}
