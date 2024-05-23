using Microsoft.AspNetCore.Http.Metadata;

namespace Asp.net_CoreProje.Areas.UserPanel.Models
{
	public class UserEditViewModel
	{
        //güncellemek istediğimiz alanları buraya yazıyoruz.

        public string Name { get; set; }

        public string SurName { get; set; }

        public string Password { get; set; }

        public string PasswordConfirm { get; set; }

        public string PictureUrl { get; set; }

        public IFormFile Picture { get; set; } //dosyanın wwwroot un içine kaydolmasını bu sağlar.

    }
}
