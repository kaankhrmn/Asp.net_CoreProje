using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Asp.net_CoreProje.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
