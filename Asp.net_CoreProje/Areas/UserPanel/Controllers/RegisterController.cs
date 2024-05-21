using Asp.net_CoreProje.Areas.UserPanel.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Asp.net_CoreProje.Areas.UserPanel.Controllers
{
        [Area("UserPanel")]

	public class RegisterController : Controller
	{
		private readonly UserManager<WriterUser> _userManager;
		
		//Generate Constructor
        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

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
					SurName = p.SurName,
					Email=p.Mail,
					UserName = p.UserName,
					ImageUrl=p.ImageUrl,
					
				};

				if (p.Password == p.ConfirmPassword)
				{
					var result = await _userManager.CreateAsync(w, p.Password);

					if (result.Succeeded)
					{
						return RedirectToAction("Index", "Default");
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
