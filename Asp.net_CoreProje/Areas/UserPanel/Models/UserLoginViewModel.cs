using System.ComponentModel.DataAnnotations;

namespace Asp.net_CoreProje.Areas.UserPanel.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Kullanıcı Adı")]
        [Required(ErrorMessage ="Kullanıcı adını giriniz")]
        public string UserName { get; set; }

        [Display(Name="Şifre")]
        [Required(ErrorMessage ="Şifrenizi giriniz")]
        public string Password { get; set; }

    }
}
