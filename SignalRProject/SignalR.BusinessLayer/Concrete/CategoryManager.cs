using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
	public class CategoryManager : ICategoryService
	{
		private readonly ICategoryDal _categorydal;

		public CategoryManager(ICategoryDal categorydal)
		{
			_categorydal = categorydal;
		}

		public int TActiveCategoryCount()
		{
			return _categorydal.ActiveCategoryCount();
		}

		public void TAdd(Category entity)
		{
			_categorydal.Add(entity);
		}

		public int TCategoryCount()
		{
			return _categorydal.CategoryCount();
		}

		public void TDelete(Category entity)
		{
			_categorydal.Delete(entity);
		}

		public Category TGetById(int id)
		{
			return _categorydal.GetById(id);
		}

		public List<Category> TGetListAll()
		{
			return _categorydal.GetListAll();
		}

		public int TPassiveCategoryCount()
		{
			return _categorydal.PassiveCategoryCount();
		}

		public void TUpdate(Category entity)
		{
			_categorydal.Update(entity);
		}
	}
}
