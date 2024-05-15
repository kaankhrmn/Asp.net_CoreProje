using Microsoft.AspNetCore.Mvc;

namespace Asp.net_CoreProje.Areas.UserPanel.Controllers
{
	public class DefaultController : Controller
	{
		[Area("UserPanel")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
