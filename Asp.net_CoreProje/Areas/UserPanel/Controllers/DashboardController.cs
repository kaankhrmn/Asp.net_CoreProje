using Microsoft.AspNetCore.Mvc;

namespace Asp.net_CoreProje.Areas.UserPanel.Controllers
{
	[Area("UserPanel")]

	public class DashboardController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
