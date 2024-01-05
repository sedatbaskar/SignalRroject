using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;

namespace SignalR.WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultBookATableComponentPartial:ViewComponent
    {
       public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
