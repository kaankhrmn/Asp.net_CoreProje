using Microsoft.AspNetCore.Mvc;

namespace Asp.net_CoreProje.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
