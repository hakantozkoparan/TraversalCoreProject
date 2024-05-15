using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProject.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage="Lütfen adınızı giriniz:")]
        public string Name { get; set; }
		[Required(ErrorMessage = "Lütfen soyadınızı giriniz:")]
		public string Surname { get; set; }
		[Required(ErrorMessage = "Lütfen cinsiyeti giriniz:")]
		public string Gender { get; set; }

		[Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz:")]
		public string Username { get; set; }

		[Required(ErrorMessage = "Lütfen mailinizi giriniz:")]
		public string Mail { get; set; }

		[Required(ErrorMessage = "Lütfen şifreyi giriniz:")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz:")]
		[Compare("Password", ErrorMessage = "Şifreler uyuşmuyor")] // Password ile ConfirmPassword aynı olmalı
		public string ConfirmPassword { get; set; }
	}
}
