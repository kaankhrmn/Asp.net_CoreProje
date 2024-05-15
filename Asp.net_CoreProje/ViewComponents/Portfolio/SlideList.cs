using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Asp.net_CoreProje.ViewComponents.Portfolio
{
    public class SlideList : ViewComponent
    {
        PortfolioManager portfolioManager= new PortfolioManager(new EfPortfolioDal());

        public IViewComponentResult Invoke()
        {
            var values=portfolioManager.GetList();
            return View(values);
        }

    }
}
