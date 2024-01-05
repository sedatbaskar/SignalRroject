using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.Controllers
{
	public class DefaultControllers : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
