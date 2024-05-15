using Microsoft.AspNetCore.Identity;

namespace TraversalCoreProject.Models
{
	public class CustomIdentityValidator :IdentityErrorDescriber
	{
		//burada şifre hatalarını özelleştirebiliriz gelen ingilizce yazıları türkçeye çeviriyoruz program.cs identity içerisinde
		//AddErrorDescriber<CustomIdentityValidator>() eklediğimiz için buradaki hatalar çalışacak
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code = "PasswordTooShort",
				Description = $"Şifre en az {length} karakter olmalıdır."
			};
		}

		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresLower",
				Description = "Şifre en az bir küçük harf içermelidir."
			};
		}
	}
}
