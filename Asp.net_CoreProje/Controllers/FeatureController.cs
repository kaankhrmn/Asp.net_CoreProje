using Microsoft.AspNetCore.Mvc;

namespace Asp.net_CoreProje.Controllers
{
	public class FeatureController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
