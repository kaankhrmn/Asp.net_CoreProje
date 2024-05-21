using Microsoft.AspNetCore.Server.HttpSys;
using System.ComponentModel.DataAnnotations;

namespace Asp.net_CoreProje.Areas.UserPanel.Models
{
	public class UserRegisterViewModel
	{
        [Required(ErrorMessage = "Lütfen adınızı girin")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adını girin")]

        public string SurName { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı girin")]

		public string UserName { get; set; }

		[Required(ErrorMessage = "Lütfen şifreyi girin")]

		public string Password { get; set; }

		[Required(ErrorMessage = "Lütfen şifreyi tekrar girin")]
		[Compare("Password", ErrorMessage = "Şifreler uyumlu değil!")] //şifre tekrarında kontrol eder.

		public string ConfirmPassword { get; set; } //şifre onaylama

        [Required(ErrorMessage = "Lütfen görsel girin")]

        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Lütfen mail girin")]

		public string Mail { get; set; }
	}
}
