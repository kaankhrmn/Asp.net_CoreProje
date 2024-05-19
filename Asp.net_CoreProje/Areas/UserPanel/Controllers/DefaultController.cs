using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Asp.net_CoreProje.Areas.UserPanel.Controllers
{
	[Area("UserPanel")]
	//[Authorize]

	public class DefaultController : Controller
	{
		AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());
        
		public IActionResult Index()
		{
			var values = announcementManager.GetList();
			return View(values);
		}

		[HttpGet]
		public IActionResult AnnouncementDetails(int id)
		{
			Announcement announcement= announcementManager.TGetById(id);
			return View(announcement);
		}
	}
}
