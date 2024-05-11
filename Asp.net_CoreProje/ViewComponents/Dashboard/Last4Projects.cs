using BussinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Asp.net_CoreProje.ViewComponents.Dashboard
{
    public class Last4Projects : ViewComponent
    {

        public IViewComponentResult Invoke() 
        {
            return View(); 
        }

    }
}
