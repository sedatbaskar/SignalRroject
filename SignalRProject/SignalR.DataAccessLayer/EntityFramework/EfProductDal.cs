using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Abstract;
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
	public class EfProductDal : GenericRepositories<Product>, IProductDal
	{
		public EfProductDal(SignalRContext context) : base(context)
		{
		}

		public List<Product> GetProductsWithCategories()
		{
			var context = new SignalRContext();
			var values = context.Product.Include(x => x.Category).ToList();
			return values;
		}

		public decimal ProductAvg()
		{
			var context = new SignalRContext();
			var values = context.Product.Average(x => x.Price);
			return values;
		}

        public decimal ProductAvgPriceByHamburger()
        {
            using var context = new SignalRContext();
            return context.Product.Where(x => x.CategoryId == (context.Categorys.Where(y => y.CategoryName == "Hamburger").Select
            (z => z.CategoryID).FirstOrDefault())).Average(w => w.Price);
        }

        public int ProductCount()
		{
			using var context = new SignalRContext();
			return context.Product.Count();
		}

		public int ProductCountbyCategoryNameDrink()
		{
			using var context = new SignalRContext();
			return context.Product.Where(x => x.CategoryId == (context.Categorys.Where(y => y.CategoryName == "içecek").Select
			(z => z.CategoryID).FirstOrDefault())).Count();
		}

        public int ProductCountbyCategoryNameHamburger()
        {
            using var context = new SignalRContext();

            var hamburgerCategoryId = context.Categorys
                .FirstOrDefault(category => category.CategoryName == "Hamburger")?.CategoryID;

            if (hamburgerCategoryId.HasValue)
            {
                var productCount = context.Product
                    .Count(product => product.CategoryId == hamburgerCategoryId);

                return productCount;
            }

            return 0; // Varsayılan olarak 0 döndür
        }

        public string ProductNamePriceByMax()
		{
			using var context = new SignalRContext();

			var mostExpensiveProduct = context.Product
				.OrderByDescending(p => p.Price)
				.FirstOrDefault();
			return $"{mostExpensiveProduct?.ProductName}";


			
		}



		public string ProductNamePriceByMin()
		{
			using var content = new SignalRContext();

			var cheapestProduct = content.Product
				.OrderBy(p => p.Price)
				.FirstOrDefault();
			return $"{cheapestProduct?.ProductName}";
		}
	}
}
