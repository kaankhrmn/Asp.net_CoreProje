using Asp.net_CoreProje.Areas.UserPanel.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Asp.net_CoreProje.Areas.UserPanel.Controllers
{
	public class RegisterController : Controller
	{
		private readonly UserManager<WriterUser> _userManager;
		
		//Generate Constructor
        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [Area("UserPanel")]

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(UserRegisterViewModel p)
		{
			if (ModelState.IsValid)
			{

				WriterUser w = new WriterUser()
				{
					Name = p.Name,
					Email = p.Mail,
					UserName = p.UserName,
					ImageUrl = p.ImageUrl
				};

				if (p.Password == p.ConfirmPassword)
				{
					var result = await _userManager.CreateAsync(w, p.Password);

					if (result.Succeeded)
					{
						return RedirectToAction("Index", "Login");
					}
					else
					{
						foreach (var item in result.Errors)
						{
							ModelState.AddModelError("", item.Description);
						}
					}
				}
			}
			return View(p);
		}
	}
}
