using Asp.net_CoreProje.Areas.UserPanel.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Asp.net_CoreProje.Areas.UserPanel.Controllers
{
	[Area("UserPanel")]

	public class ProfileController : Controller
	{
		private readonly UserManager<WriterUser> _userManager;

		public ProfileController(UserManager<WriterUser> userManager)
		{
			_userManager = userManager;
		}


		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			UserEditViewModel model = new UserEditViewModel();
			model.Name = values.Name;
			model.SurName = values.SurName;
			model.PictureUrl = values.ImageUrl;
			return View(model);
		}


		[HttpPost]
		public async Task<IActionResult> Index(UserEditViewModel p)
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			if (p.Picture != null)
			{
				var resource = Directory.GetCurrentDirectory(); //aktif olan yolu al demek.
				var extension = Path.GetExtension(p.Picture.FileName); //yolu dosya adı olarak alır.
				var imagename = Guid.NewGuid()+extension;
				var savelocation = resource + "/wwwroot/UserImage" + imagename;
				var stream = new FileStream(savelocation , FileMode.Create);
				await p.Picture.CopyToAsync(stream);
				values.ImageUrl = imagename;
			}
			values.Name = p.Name;
			values.SurName = p.SurName;
			var result = await _userManager.UpdateAsync(values);
			if (result.Succeeded)
			{
				return RedirectToAction("Index", "Default");
			}
			return View();
		}
	}
}
