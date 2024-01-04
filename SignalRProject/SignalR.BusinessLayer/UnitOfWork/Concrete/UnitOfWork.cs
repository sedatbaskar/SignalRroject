using SignalR.BusinessLayer.Abstract;
using SignalR.BusinessLayer.Concrete;
using SignalR.BusinessLayer.UnitOfWork.Abstract;
using SignalR.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.UnitOfWork.Concrete
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly SignalRContext _context;

		public UnitOfWork(SignalRContext context)
		{
			_context = context;

			
		}
		public IAboutService About { get; set; }

		public IBookingService Booking { get; set; }

		public ICategoryService Category { get; set; }

		public IContactService Contact { get; set; }

		public IDiscountService Discount { get; set; }

		public IFeatureService Feature { get; set; }

		public IMenuTableService MenuTable { get; set; }

		public IMoneyCasesService MoneyCases { get; set; }

		public IOrderDetailService OrderDetail { get; set; }

		public IOrderService Order { get; set; }

		public IProductService Product { get; set; }

		public ISocialMediaService SocialMedia { get; set; }

		public ITestimonialService Testimonial { get; set; }
	}
}
