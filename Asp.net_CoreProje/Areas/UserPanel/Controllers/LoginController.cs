using Asp.net_CoreProje.Areas.UserPanel.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Asp.net_CoreProje.Areas.UserPanel.Controllers
{   
    [Area("UserPanel")]

    public class LoginController : Controller
    {

        private readonly SignInManager<WriterUser> _signInManager;

        public LoginController(SignInManager<WriterUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        //Giriş işlemini gerçekleştiriyoruz.
        public async Task<IActionResult> Index(UserLoginViewModel p)
        {
            if (ModelState.IsValid) //login işleminin kontrolünü sağlıyoruz.
            {
                var result = await _signInManager.PasswordSignInAsync(p.UserName,p.Password,true,true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index","Default");
                }
                else
                {
                    ModelState.AddModelError("","Hatalı kullanıcı adı veya şifre");
                }
            }
            return View();
        }
    }
}
