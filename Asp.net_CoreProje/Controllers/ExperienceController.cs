using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace Asp.net_CoreProje.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());

        public IActionResult Index()
        {
			ViewBag.v1 = "Deneyim Listesi";
			ViewBag.v2 = "Deneyimler";
			ViewBag.v3 = "Deneyim Listesi";
			var values = experienceManager.GetList();
            return View(values);
        }

        //yetenek ekleme
        [HttpGet]
        public IActionResult AddExperience()
        {
			ViewBag.v1 = "Deneyim Ekleme";
			ViewBag.v2 = "Deneyimler";
			ViewBag.v3 = "Deneyim Ekleme";
			return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            experienceManager.TAdd(experience);
            return RedirectToAction("Index");
        }

        //silme işlemi
        public IActionResult DeleteExperience(int id)
        {
            var values = experienceManager.TGetById(id);
            experienceManager.TDelete(values);
            return RedirectToAction("Index");
        }

        //güncelleme işlemi
        [HttpGet]
        public IActionResult EditExperience(int id)
        {
			ViewBag.v1 = "Deneyim Düzenle";
			ViewBag.v2 = "Deneyimler";
			ViewBag.v3 = "Deneyim Düzenle";
			var values = experienceManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {
            experienceManager.TUpdate(experience);
            return RedirectToAction("Index");
        }

	}
}
