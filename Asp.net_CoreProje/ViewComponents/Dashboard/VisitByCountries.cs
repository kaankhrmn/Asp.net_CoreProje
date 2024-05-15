using Microsoft.AspNetCore.Mvc;

namespace Asp.net_CoreProje.ViewComponents.Dashboard
{
	public class VisitByCountries : ViewComponent
	{
		public IViewComponentResult Invoke() 
		{  
			return View();
		}
	}
}
