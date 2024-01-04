using SignalR.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.UnitOfWork.Abstract
{
	public interface IUnitOfWork 
	{
		IAboutService About { get; }
		IBookingService Booking { get; }
		ICategoryService Category { get; }
		IContactService Contact { get; }
		IDiscountService Discount { get; }
		IFeatureService Feature { get; }
		IMenuTableService MenuTable { get; }
		IMoneyCasesService MoneyCases { get; }
		IOrderDetailService OrderDetail { get; }
		IOrderService Order { get; }
		IProductService Product { get; }
		ISocialMediaService SocialMedia { get; }
		ITestimonialService Testimonial { get; }



	}
}
