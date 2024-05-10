using Microsoft.AspNetCore.Mvc;

namespace Asp.net_CoreProje.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
