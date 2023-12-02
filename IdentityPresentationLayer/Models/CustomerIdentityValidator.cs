using Microsoft.AspNetCore.Identity;

namespace IdentityPresentationLayer.Models
{
	public class CustomerIdentityValidator : IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code = "PasswordTooShort",
				Description = $"Porala en az  {length} olmalıdır"

			};
		}
		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresUpper",
				Description = "bir kararter giriniz"
			};
		}
		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError()
		}
	}
}
