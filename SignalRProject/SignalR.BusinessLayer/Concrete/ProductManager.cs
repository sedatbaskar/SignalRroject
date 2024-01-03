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
	public class ProductManager : IProductService
	{
		private readonly IProductDal _productDal;

		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}

		public void TAdd(Product entity)
		{
			_productDal.Add(entity);
		}

		public void TDelete(Product entity)
		{
			_productDal.Delete(entity);
		}

		public Product TGetById(int id)
		{
			return _productDal.GetById(id);
		}

		public List<Product> TGetListAll()
		{
			return _productDal.GetListAll();
		}

		public List<Product> TGetProductsWithCategories()
		{
			return _productDal.GetProductsWithCategories();
		}

		public decimal TProductAvg()
		{
			return _productDal.ProductAvg();
		}

        public decimal TProductAvgPriceByHamburger()
        {
           return _productDal.ProductAvgPriceByHamburger();
        }

        public int TProductCount()
		{
			return _productDal.ProductCount();
		}

		public int TProductCountbyCategoryNameDrink()
		{
			return _productDal.ProductCountbyCategoryNameDrink();
		}

		public int TProductCountbyCategoryNameHamburger()
		{
			return _productDal.ProductCountbyCategoryNameHamburger();
		}

		public string TProductNamePriceByMax()
		{
			return _productDal.ProductNamePriceByMax();
		}

		public string TProductNamePriceByMin()
		{
			return _productDal.ProductNamePriceByMin();
		}

		public void TUpdate(Product entity)
		{
			_productDal.Update(entity);
		}
	}
}
